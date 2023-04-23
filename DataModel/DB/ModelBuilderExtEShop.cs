using DataModel.Entity.EntityEShop;
using Microsoft.EntityFrameworkCore;


namespace DataModel.DB
{
    public static class ModelBuilderExtEShop
    {
        // Seed Category.
        public static void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1, Code ="CAT0001", Name ="Head Phones and Ear Phones", Description="Head Phones Category", Icon= "fa fa-headphones",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new Category()
                {
                    ID = 2, Code ="CAT0002", Name = "Computers & Tablets", Description= "Computers & Tablets Category", Icon= "fa fa-desktop",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                
                new Category()
                {
                    ID = 3, Code ="CAT0003", Name = "Phones & Wearables", Description= "Phones & Wearables Category", Icon= "fa fa-desktop",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new Category()
                {
                    ID = 4, Code ="CAT0004", Name = "TV, Blu-ray & Home Theatre", Description= "TV, Blu-ray & Home Theatre Category", Icon= "fa fa-desktop",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                 new Category()
                {
                    ID = 5, Code ="CAT0005", Name = "Kitchen Appliance", Description= "Kitchen appliance Category", Icon= "fa fa-desktop",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new Category()
                {
                    ID = 6, Code ="CAT0006", Name = "Cattle & Sheep", Description= "Cattle & Sheep Category", Icon= "fa fa-desktop",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                },
                new Category()
                {
                    ID = 7, Code ="CAT0007", Name = "Fashion & Jewelry", Description= "Items under fashion and jewelry", Icon= "fa fa-desktop",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12)
                });               
         }


        // Seed Supplier.
        public static void SeedSupplier(ModelBuilder builder)
        {
            builder.Entity<Supplier>().HasData(
                new Supplier()
                {
                    ID = 1, Code = "SUP001", Name="Punjas Fiji", Phone="9966331", Email="info@punjas.com", Address="Vitogo Prade Lautoka" , City="Lautoka",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                 new Supplier()
                {
                    ID = 2, Code = "SUP002", Name="Lautoka Engineering", Phone="9996663", Email="info@lautokaeng.com", Address="Vitogo Prade Lautoka" , City="Lautoka",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                
                },
                  new Supplier()
                {
                    ID = 3, Code = "SUP003", Name="Asco Motors", Phone="9996343", Email="request@asco.com.fj", Address="Vitogo Prade Lautoka" , City="Lautoka",
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Supplier()
                {
                    ID = 4, Code = "SUP004", Name="Payal Jewelers, Tavua", Phone="9996343", Email="info@payaljewel.com", 
                      Address="Main street" , City="Tavua", CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                });
        }

         // Seed ProductUnit.
        public static void SeedProductUnit(ModelBuilder builder)
        {
            builder.Entity<ProductUnit>().HasData(
                new ProductUnit()
                {
                    ID = 1, Unit="Kilogram", Name="Kilogram", Weight=100, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductUnit()
                {
                    ID = 2, Unit="Litre", Name="Liter", Weight=1000, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductUnit()
                {
                    ID = 3, Unit="Meter", Name="Meter", Weight=5.5F, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                });
        }
        
         // Seed Product.
        public static void SeedProduct(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ID = 1, Code="PR0001", Name="Professional Head Phone", Description= "Head phone for professionals", Rating=4, UnitPrice=49.99M, 
                    IsOnPromotion=true,Quantity=320, CategoryID=1 , SupplierID=2, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new Product()
                {
                    ID = 2, Code="PR0002", Name="Head Phone", Description= "Great gear for professionals, ultra sound quality", Rating=2, UnitPrice=36.49M, 
                    IsOnPromotion=false,Quantity=76, CategoryID=1 , SupplierID=2, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new Product()
                {
                    ID = 3, Code="PR0003", Name= "Wrist Watch", Description= "Phone and time on your wrist", Rating=5, UnitPrice=89.99M, 
                    IsOnPromotion=false,Quantity=60, CategoryID=3 , SupplierID=1, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new Product()
                {
                    ID = 4, Code="PR0004", Name= "French Door Fridge", Description= "With its spacious capacity and convenient design, the Electrolux 609L UltimateTaste 900 French Door Fridge with Ice & Water Dispenser - Natural Stainless is a practical storage space option for busy kitchens.", 
                    Rating=5, UnitPrice=2999M, IsOnPromotion=false,Quantity=40, CategoryID=5 , SupplierID=3, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new Product()
                {
                    ID = 5, Code="PR0005", Name= "Microwave Oven", Description= "Samsung 40L Microwave Oven - Stainless Steel\r\nThis stylish Samsung Solo microwave features 40L capacity, auto defrost function, one minute plus, sensor technology and more.\r\n", 
                    Rating=3, UnitPrice=499M,IsOnPromotion=false,Quantity=1056, CategoryID=5 , SupplierID=3, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new Product()
                {
                    ID = 6, Code="PR0006", Name= "Sony Smart TV MASTER", Description= "Experience lifelike visuals and enveloping sound as you watch your favourite movies and TV series with the Sony 83-inch XR MASTER series A90J 4K UHD OLED Google TV. It features a frameless design to minimise distractions and blend seamlessly with the rest of your room's décor scheme.", 
                    Rating=3, UnitPrice=2499M,IsOnPromotion=false,Quantity=106, CategoryID=4 , SupplierID=3, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Product()
                {
                    ID = 7, Code="PR0007", Name= "Sound Bar", Description= "The JBL BAR 1300 11.1.4 Channel Dolby Atmos Soundbar with Detachable Speaker delivers an immersive sound experience that brings your movies, TV shows, and music to life. Featuring Dolby Atmos and DTS:X technology, this soundbar creates a 3D soundstage that surrounds you with sound from every angle. The powerful 10-inch wireless subwoofer delivers deep, punchy bass, while 4K pass-through with HDR 10 and Dolby Vision support ensures stunning picture quality. With its 6 up-firing speakers with Multibeam technology, multiple HDMI inputs, and Bluetooth and WiFi connectivity, this soundbar is the perfect addition to your home entertainment system.", 
                    Rating=5, UnitPrice=1995M,IsOnPromotion=false,Quantity=10, CategoryID=4 , SupplierID=3, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),

                },
                new Product()
                {
                    ID = 8, Code="PR0008", Name= "Pandora Timeless Pavé Double-row Ring", 
                    Description= "Maximise your sparkle with our Pandora Timeless Pavé Double-row Ring. With warm 14k rose gold plating, this hand-finished ring features two rows of clear cubic zirconia around the centre and one row facing outwards around each side, creating a slightly rounded square profile that sparkles from every angle. Wear it on its own or stacked with other Timeless Pavé rings to create as bold of a look as you want.",
                    Rating=5, UnitPrice=2995M,IsOnPromotion=false,Quantity=10, CategoryID=7 , SupplierID=4, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Product()
                {
                    ID = 9, Code="PR0009", Name= "Moissanite Necklace Sterling Silver", 
                    Description= "Maximise your sparkle with our Pandora Timeless Pavé Double-row Ring. With warm 14k rose gold plating, this hand-finished ring features two rows of clear cubic zirconia around the centre and one row facing outwards around each side, creating a slightly rounded square profile that sparkles from every angle. Wear it on its own or stacked with other Timeless Pavé rings to create as bold of a look as you want.",
                    Rating=5, UnitPrice=2995M,IsOnPromotion=false,Quantity=10, CategoryID=7 , SupplierID=4, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Product()
                {
                    ID = 10, Code="PR0010", Name= "White & Golden Pearl Pendant Necklaces", 
                    Description="Crafted with most peculiar pearls of south pacific"
                     ,Rating=5, UnitPrice=5995M,IsOnPromotion=false,Quantity=10, CategoryID=7 , SupplierID=4, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Product()
                {
                    ID = 11, Code="PR0011", Name= "18k diamond and pink sapphire necklace", 
                    Description= "London Collection 18k diamond and pink sapphire dangle necklace. 18k rose gold round diamond necklace with heart shaped pink sapphire dangles. Total diamond weight 1.17cts, total sapphire weight 3.05cts.",
                    Rating=3, UnitPrice=1995M,IsOnPromotion=false,Quantity=2, CategoryID=7 , SupplierID=4, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Product()
                {
                    ID = 12, Code="PR0012", Name= "Oval locket medium siler", 
                    Description= "<p>True magic is capturing a moment, freezing it in time to cherish forever. The locket is the keeper of those moments, with you always those feelings will remain. We designed the locket to bring all of life's precious moments close to your heart.  Wrap your memory in the metal of your choice for a truly special piece unique to you.</p>" +
                    "<p>Select from solid sterling silver, 14k rose or gold plated 2 microns on silver </br>Charm quote - With you always </br>Oval locket is 16mm x 12mm in size </br>Upload up to two images, one for each side of the locket + 1 image for the box </br>Locket's image dimensions are 13mm x 8 mm </p>",
                    Rating=4, UnitPrice=4285.75M,IsOnPromotion=false,Quantity=5, CategoryID=7 , SupplierID=4, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Product()
                {
                    ID = 13, Code="PR0013", Name= "Vintage ruby set - Sterling Silver", 
                    Description= "<table><tr><td>Detail Information:</td><td></td></tr><tr><td style={{width:\"300px\"}}>Material:</td><td style={{width:\"300px\"}}>925 Sterling Silver;</td></tr><tr><td>Center Stone_Carat Weight:</td><td>1.0 Carat;</td></tr><tr><td>Center Stone Shape:</td><td>Round Cut(6.4mm);</td></tr><tr><td>Chain Length:</td><td>400mm (+50mm);</td></tr><tr><td>Plating Color:</td><td>White Gold;</td></tr><tr><td>Stone:</td><td>Moissanite;</td></tr></table>",
                    Rating=4, UnitPrice=1285.99M,IsOnPromotion=false,Quantity=150, CategoryID=7 , SupplierID=4, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new Product()
                {
                    ID = 14, Code="PR0014", Name= "Female sheep", 
                    Description="One only female sheep for sale. Price is FJD$320.00. Located in Tavua and only pickup during working hours.",
                    Rating=1, UnitPrice=320M,IsOnPromotion=false,Quantity=1, CategoryID=6 , SupplierID=4, 
                    CreatedBy = "Ronald", IPAddress = "255.255.255.1", CreatedDate = DateTime.UtcNow.AddHours(12),
                });
        }

        // Seed Product Image
        public static void SeedProductImage(ModelBuilder builder)
        {
            builder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    ID = 1, Name= "Headphone-a-1.webp", Path= "Static/Products/PR0001/PR0001Headphone-a-1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001",
                    ProductID= 1,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 2, Name= "Headphone-a-2.webp", Path = "Static/Products/PR0001/PR0001Headphone-a-2.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001",
                    ProductID= 1,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 3, Name= "Headphone-a-3.webp", Path= "Static/Products/PR0001/PR0001Headphone-a-3.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001",
                    ProductID= 1,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 4, Name= "Headphone-a-4.webp", Path= "Static/Products/PR0001/PR0001Headphone-a-4.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001",
                    ProductID= 1,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 5, Name= "Headphone-a-5.webp", Path= "Static/Products/PR0001/PR0001Headphone-a-5.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001",
                    ProductID= 1,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },


                 new ProductImage()
                {
                    ID = 6, Name= "Headphone-b-1.webp", Path= "Static/Products/PR0002/PR0002Headphone-b-1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002",
                    ProductID= 2,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                 new ProductImage()
                {
                    ID = 7, Name= "Headphone-b-2.webp", Path= "Static/Products/PR0002/PR0002Headphone-b-2.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002",
                    ProductID= 2,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                }, new ProductImage()
                {
                    ID = 8, Name= "Headphone-b-3.webp", Path= "Static/Products/PR0002/PR0002Headphone-b-3.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002",
                    ProductID= 2,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                }, new ProductImage()
                {
                    ID = 9, Name= "Headphone-b-4.webp", Path= "Static/Products/PR0002/PR0002Headphone-b-4.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002",
                    ProductID= 2,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },


                new ProductImage()
                {
                    ID = 10, Name= "WristWatch-a-1.webp", Path= "Static/Products/PR0003/PR0003WristWatch-a-1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003",
                    ProductID= 3,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 11, Name= "WristWatch-a-2.webp", Path= "Static/Products/PR0003/PR0003WristWatch-a-2.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003",
                    ProductID= 3,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 12, Name= "WristWatch-a-3.webp", Path= "Static/Products/PR0003/PR0003WristWatch-a-3.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003",
                    ProductID= 3,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 13, Name= "WristWatch-a-4.webp", Path= "Static/Products/PR0003/PR0003WristWatch-a-4.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003",
                    ProductID= 3,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },


                new ProductImage()
                {
                    ID = 14, Name= "PR0004Freeze1.webp", Path= "Static/Products/PR0004/PR0004Freeze1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004",                 
                    ProductID= 4,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 15, Name= "PR0004Freeze2.jpg", Path= "Static/Products/PR0004/PR0004Freeze2.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004",
                    ProductID= 4,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 16, Name= "PR0004Freeze3.jpg", Path= "Static/Products/PR0004/PR0004Freeze3.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004",
                    ProductID= 4,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 17, Name= "PR0004Freeze4.jpg", Path= "Static/Products/PR0004/PR0004Freeze4.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004",
                    ProductID= 4,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 18, Name= "PR0004Freeze5.jpg", Path= "Static/Products/PR0004/PR0004Freeze5.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004",
                    ProductID= 4,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 19, Name= "PR0004Freeze6.jpg", Path= "Static/Products/PR0004/PR0004Freeze6.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004",
                    ProductID= 4,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },



                new ProductImage()
                {
                    ID = 20, Name= "PR0005Micowave1.jpg", Path= "Static/Products/PR0005/PR0005Micowave1.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005",
                    ProductID= 5,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 21, Name= "PR0005Micowave2.jpg", Path= "Static/Products/PR0005/PR0005Micowave2.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005",
                    ProductID= 5,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 22, Name= "PR0005Micowave3.jpg", Path= "Static/Products/PR0005/PR0005Micowave3.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005",
                    ProductID= 5,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 23, Name= "PR0005Micowave4.jpg", Path= "Static/Products/PR0005/PR0005Micowave4.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005",
                    ProductID= 5,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                new ProductImage()
                {
                    ID = 24, Name= "PR0006SonySmartTV_1.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductImage()
                {
                    ID = 25, Name= "PR0006SonySmartTV_2.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_2.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 26, Name= "PR0006SonySmartTV_3.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_3.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductImage()
                {
                    ID = 27, Name= "PR0006SonySmartTV_4.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_4.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductImage()
                {
                    ID = 28, Name= "PR0006SonySmartTV_5.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_5.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductImage()
                {
                    ID = 29, Name= "PR0006SonySmartTV_6.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_6.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductImage()
                {
                    ID = 30, Name= "PR0006SonySmartTV_7.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_7.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },new ProductImage()
                {
                    ID = 31, Name= "PR0006SonySmartTV_8.jpg", Path= "Static/Products/PR0006/PR0006SonySmartTV_8.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006",
                    ProductID= 6,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },

                new ProductImage()
                {
                    ID = 32, Name= "PR0007SoundBar_1.jpg", Path= "Static/Products/PR0007/PR0007SoundBar_1.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007",
                    ProductID= 7,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 33, Name= "PR0007SoundBar_2.jpg", Path= "Static/Products/PR0007/PR0007SoundBar_2.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007",
                    ProductID= 7,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 34, Name= "PR0007SoundBar_3.jpg", Path= "Static/Products/PR0007/PR0007SoundBar_3.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007",
                    ProductID= 7,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 35, Name= "PR0007SoundBar_4.jpg", Path= "Static/Products/PR0007/PR0007SoundBar_4.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007",
                    ProductID= 7,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 36, Name= "PR0007SoundBar_5.jpg", Path= "Static/Products/PR0007/PR0007SoundBar_5.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007",
                    ProductID= 7,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                
                new ProductImage()
                {
                    ID = 37, Name= "PR0008diamondring8ck_1.webp", Path= "Static/Products/PR0008/PR0008diamondring8ck_1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008",
                    ProductID= 8,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 38, Name= "PR0008diamondring8ck_2.webp", Path= "Static/Products/PR0008/PR0008diamondring8ck_2.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008",
                    ProductID= 8,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                 new ProductImage()
                {
                    ID = 39, Name= "PR0008diamondring8ck_3.gif", Path= "Static/Products/PR0008/PR0008diamondring8ck_3.gif", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008",
                    ProductID= 8,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 40, Name= "PR0008diamondring8ck_4.webp", Path= "Static/Products/PR0008/PR0008diamondring8ck_4.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008",
                    ProductID= 8,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                new ProductImage()
                {
                    ID = 41, Name= "PR0009moissanite-necklace_1.webp", Path= "Static/Products/PR0009/PR0009moissanite-necklace_1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009",
                    ProductID= 9,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 42, Name= "PR0009moissanite-necklace_2.webp", Path= "Static/Products/PR0009/PR0009moissanite-necklace_2.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009",
                    ProductID= 9,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 43, Name= "PR0009moissanite-necklace_3.webp", Path= "Static/Products/PR0009/PR0009moissanite-necklace_3.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009",
                    ProductID= 9,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 44, Name= "PR0009moissanite-necklace_4.webp", Path= "Static/Products/PR0009/PR0009moissanite-necklace_4.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009",
                    ProductID= 9,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 45, Name= "PR0009moissanite-necklace_5.webp", Path= "Static/Products/PR0009/PR0009moissanite-necklace_5.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009",
                    ProductID= 9,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                new ProductImage()
                {
                    ID = 46, Name= "PR0010Pearls-natrualstone_1.jpg", Path= "Static/Products/PR0010/PR0010Pearls-natrualstone_1.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010",
                    ProductID= 10,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 47, Name= "PR0010Pearls-natrualstone_2.jpg", Path= "Static/Products/PR0010/PR0010Pearls-natrualstone_2.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010",
                    ProductID= 10,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 48, Name= "PR0010Pearls-natrualstone_3.jpg", Path= "Static/Products/PR0010/PR0010Pearls-natrualstone_3.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010",
                    ProductID= 10,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 49, Name= "PR0010Pearls-natrualstone_4.jpg", Path= "Static/Products/PR0010/PR0010Pearls-natrualstone_4.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010",
                    ProductID= 10,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 50, Name= "PR0010Pearls-natrualstone_5.jpg", Path= "Static/Products/PR0010/PR0010Pearls-natrualstone_5.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010",
                    ProductID= 10,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                new ProductImage()
                {
                    ID = 51, Name= "PR0011diamond-pink-sapphire_1.webp", Path= "Static/Products/PR0011/PR0011diamond-pink-sapphire_1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0011",
                    ProductID= 11,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                new ProductImage()
                {
                    ID = 52, Name= "PR0012oval_locket_siler_1.webp", Path= "Static/Products/PR0012/PR0012oval_locket_siler_1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012",
                    ProductID= 12,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 53, Name= "PR0012oval_locket_siler_2.webp", Path= "Static/Products/PR0012/PR0012oval_locket_siler_2.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012",
                    ProductID= 12,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 54, Name= "PR0012oval_locket_siler_3.webp", Path= "Static/Products/PR0012/PR0012oval_locket_siler_3.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012",
                    ProductID= 12,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 55, Name= "PR0012oval_locket_siler_4.webp", Path= "Static/Products/PR0012/PR0012oval_locket_siler_4.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012",
                    ProductID= 12,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 56, Name= "PR0012oval_locket_siler_5.webp", Path= "Static/Products/PR0012/PR0012oval_locket_siler_5.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012",
                    ProductID= 12,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                new ProductImage()
                {
                    ID = 57, Name= "PR0013vintagerubyset_1.webp", Path= "Static/Products/PR0013/PR0013vintagerubyset_1.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013",
                    ProductID= 13,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 58, Name= "PR0013vintagerubyset_2.webp", Path= "Static/Products/PR0013/PR0013vintagerubyset_2.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013",
                    ProductID= 13,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 59, Name= "PR0013vintagerubyset_3.webp", Path= "Static/Products/PR0013/PR0013vintagerubyset_3.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013",
                    ProductID= 13,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 60, Name= "PR0013vintagerubyset_4.webp", Path= "Static/Products/PR0013/PR0013vintagerubyset_4.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013",
                    ProductID= 13,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 61, Name= "PR0013vintagerubyset_5.webp", Path= "Static/Products/PR0013/PR0013vintagerubyset_5.webp", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013",
                    ProductID= 13,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                
                new ProductImage()
                {
                    ID = 62, Name= "PR0014sheep_1.jpg", Path= "Static/Products/PR0014/PR0014sheep_1.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014",
                    ProductID= 14,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 63, Name= "PR0014sheep_2.jpg", Path= "Static/Products/PR0014/PR0014sheep_2.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014",
                    ProductID= 14,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 64, Name= "PR0014sheep_3.jpg", Path= "Static/Products/PR0014/PR0014sheep_3.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014",
                    ProductID= 14,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 65, Name= "PR0014sheep_4.jpg", Path= "Static/Products/PR0014/PR0014sheep_4.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014",
                    ProductID= 14,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                },
                new ProductImage()
                {
                    ID = 66, Name= "PR0014sheep_5.jpg", Path= "Static/Products/PR0014/PR0014sheep_5.jpg", Description= "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014",
                    ProductID= 14,CreatedBy = "Ronald", IPAddress = "45.241.250.15", CreatedDate = DateTime.UtcNow.AddHours(12),
                });
        }
    }
}
