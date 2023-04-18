using DataModel.DB;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using SchoolApiv2.Extentions;
using SchoolApiv2.Extentions.Policy;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SchoolApiv2.Repository.EShopRepository;
using SchoolApiv2.Util;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SchoolDBContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDBConn")));

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("App_Settings"));

//builder.Services.AddAutoMapper(typeof(Program)); // Changed on 18-03-23 in attempt to reslove date format error on Azure
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Initialize JWT authorization configuration 
var key = Encoding.ASCII.GetBytes(builder.Configuration["App_Settings:Secret"]);

var tokenValidationParams = new TokenValidationParameters
{
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(key),
   
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidIssuer = builder.Configuration["App_Settings:Issuer"],
    ValidAudience = builder.Configuration["App_Settings:Audience"],
    ValidateLifetime = true,
    RequireExpirationTime = false,
    ClockSkew = TimeSpan.Zero
};

builder.Services.AddSingleton(tokenValidationParams);

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
  .AddJwtBearer(jwt => {
      jwt.SaveToken = true;
      jwt.TokenValidationParameters = tokenValidationParams;
      

  });


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<AuthServices>();

// Dependency injection for authorization policy requirements
builder.Services.AddSingleton<IAuthorizationHandler, MinimumTimeSpendHandler>();
builder.Services.AddSingleton<IAuthorizationHandler, ManageUserRoleHandler>();
//builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

#region Repositories

//builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IUserTypesRepository, UserTypesRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<IAssessmentRepository, AssessmentRepository>();
builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
builder.Services.AddScoped<IScoreRepository, ScoreRepository>();
builder.Services.AddScoped<IPrerequisiteRepository, PrerequisiteRepository>();
builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
builder.Services.AddScoped<ISchoolYearRepository, SchoolYearRepository>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICustomerRespository, CustomerRepository>();


#endregion

// add authorization policy
builder.Services.AddAuthorizationCore(options =>
{
    options.AddPolicy("UserRoleManagePermission",
        policy => policy
        .RequireRole("Admin")
        .Requirements.Add( new ManageUserRoleRequirement("admin@admin.com"))  );

    options.AddPolicy(
        "SuperUser",
         policy => policy     
        .RequireRole("Admin") 
        .RequireAssertion(c => c.User.HasClaim(claim => claim.Value == "r@m.com"))
    );


});

// add cors to route
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => {
            builder
             .WithOrigins("http://localhost:3000", "https://localhost:3000", "https://localhost:443",
             "https://fijii.netlify.app", "https://www.netlify.app",
            "https://ronaldfiji.github.io", "https://ronaldfiji.github.io/user/login", "https://ronaldfiji.github.io/user/profile",
            "https://ronaldfiji.github.io/schoolcli")  // commetn at 7.13pm 18-03-23
           // .AllowAnyOrigin()
            .SetIsOriginAllowed(origin => true) // This line and AllowAnyOrigin() is same function.
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
            .WithExposedHeaders("X-Pagination");
            
        });
});



var app = builder.Build();

// Configure the HTTP request pipeline.

//if (app.Environment.IsDevelopment())//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseStaticFiles(); // Serving static files on default wwwroot directory

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, @"Resource\Static")),
    RequestPath = new PathString("/api/static")
    /* Image will be served directly on root when RequestPath is not specified. Specify
    folder name and sub folder name after PhysicalFileProvider path e.g. https://localhost:7089/static/products/pr002/PR002soccerMan.jpg
    */
});

app.UseCors("AllowAll");

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//app.UseCustomFunction(); // Calling customer static fuction.

app.Run();
