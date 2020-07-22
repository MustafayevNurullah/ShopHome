using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopHome.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Sliders>().HasData(
                    new Sliders() { Id =1 }
                );
            modelBuilder.Entity<Offers>().HasData(
                    new Offers() { Id = 1,Name="Xiaomi",Price=159.3,Path="img/Offer1.jpg" },
                    new Offers() { Id = 2,Name="Huawei",Price=137.3,Path="img/Offer2.jpg" },
                    new Offers() { Id = 3,Name="Samsung",Price=129.3,Path="img/Offer3.jpg" },
                    new Offers() { Id = 4,Name="Xiaomi",Price=159.3,Path="img/Offer4.jpg" },
                    new Offers() { Id = 5,Name="Xiaomi",Price=159.3,Path="img/Offer5.jpg" },
                    new Offers() { Id = 6,Name="Xiaomi",Price=159.3,Path="img/Offer6.jpg" },
                    new Offers() { Id = 7,Name="Xiaomi",Price=159.3,Path="img/Offer7.jpg" },
                    new Offers() { Id = 8,Name="Huawei",Price=137.3,Path="img/Offer8.jpg" },
                    new Offers() { Id = 9,Name="Samsung",Price=129.3,Path="img/Offer9.jpg" },
                    new Offers() { Id = 10,Name="Xiaomi",Price=159.3,Path="img/Offer10.jpg" },
                    new Offers() { Id = 11,Name="Xiaomi",Price=159.3,Path="img/Offer11.jpg" },
                    new Offers() { Id = 12,Name="Xiaomi",Price=159.3,Path="img/Offer12.jpg" },
                 new Offers() { Id = 13,Name="Xiaomi",Price=159.3,Path="img/Offer13.jpg" },
                    new Offers() { Id = 14,Name="Xiaomi",Price=159.3,Path="img/Offer14.jpg" },
                    new Offers() { Id = 15,Name="Xiaomi",Price=159.3,Path="img/Offer15.jpg" },
                    new Offers() { Id = 16,Name="Xiaomi",Price=159.3,Path="img/Offer16.jpg" },
                    new Offers() { Id = 17,Name="Huawei",Price=137.3,Path="img/Offer17.jpg" },
                    new Offers() { Id = 18,Name="Samsung",Price=129.3,Path="img/Offer18.jpg" },
                    new Offers() { Id = 19,Name="Xiaomi",Price=159.3,Path="img/Offer19.jpg" },
                    new Offers() { Id = 20,Name="Xiaomi",Price=159.3,Path="img/Offer20.jpg" }
                
                    );
            modelBuilder.Entity<Fixed_photo>().HasData(
                new Fixed_photo() { Id=1,Path="img/photo1.jpg"},
                new Fixed_photo() { Id=2,Path="img/photo2.jpg"}

                );
            modelBuilder.Entity<Slider>().HasData(
                
                new Slider() { Id=1,Path="img/slider1.jpg"},
                new Slider() { Id=2,Path="img/slider2.jpg"},
                new Slider() { Id=3,Path="img/slider3.jpg"},
                new Slider() { Id=4,Path="img/slider4.jpg"},
                new Slider() { Id=5,Path="img/slider5.jpg"}
                );
            modelBuilder.Entity<Today_is_offer>().HasData(
                
                new Today_is_offer() { Id=1,Path="img/today_offer1.jpg",Name="Xiaomi",Price=332.7},
                new Today_is_offer() { Id=2,Path="img/today_offer2.jpg",Name="Lenovo",Price=302.7},
                new Today_is_offer() { Id=3,Path="img/today_offer3.jpg",Name="Samsung",Price=222.9},
                new Today_is_offer() { Id=4,Path="img/today_offer4.jpg",Name="Xiaomi",Price=332.7},
                new Today_is_offer() { Id=5,Path="img/today_offer5.jpg",Name="Xiaomi",Price=332.7},
                new Today_is_offer() { Id=6,Path="img/today_offer6.jpg",Name="Xiaomi",Price=332.7},
                new Today_is_offer() { Id=7,Path="img/today_offer7.jpg",Name="Xiaomi",Price=332.7},
                new Today_is_offer() { Id=8,Path="img/today_offer8.jpg",Name="Xiaomi",Price=332.7},
                new Today_is_offer() { Id=9,Path="img/today_offer9.jpg",Name="Xiaomi",Price=332.7},
                new Today_is_offer() { Id=10,Path="img/today_offer10.jpg",Name="Xiaomi",Price=332.7}
                );



         modelBuilder.Entity<Product>().HasData(
                    new Product() { Id = 1, Name = "Apple", Price = 100.40, SubCategoryId = 1 ,Path="img/telefonlar_Apple.jpg" },
               new Product() { Id = 2, Name = "Samsung", Price = 354.0, SubCategoryId = 1 ,Path = "img/telefonlar_Samsung.jpg" },
                  new Product() { Id = 3, Name = "Xiaomi", Price = 425.0, SubCategoryId = 1, Path = "img/telefonlar_Xiaomi.jpg" },
                 new Product() { Id = 4, Name = "Huawei", Price = 432.0, SubCategoryId = 1, Path = "img/telefonlar_Huawei.jpg" },
                new Product() { Id = 5, Name = "BQ", Price = 500.0, SubCategoryId = 1, Path = "img/telefonlar_BQ.jpg" },
               new Product() { Id = 6, Name = "Honor", Price = 354.0, SubCategoryId = 1, Path = "img/telefonlar_Honor.jpg" },
               new Product() { Id = 7, Name = "OnePlus", Price = 354.0, SubCategoryId = 1, Path = "img/telefonlar_OnePLus.jpg" },
               new Product() { Id = 8, Name = "Hoffmann", Price = 354.0, SubCategoryId = 1, Path = "img/telefonlar_Hoffmann.jpg" },
               new Product() { Id = 9, Name = "Sony", Price = 354.0, SubCategoryId = 1, Path = "img/telefonlar_Sony.jpg" },
               new Product() { Id = 10, Name = "Nokia", Price = 354.0, SubCategoryId = 1, Path = "img/telefonlar_Nokia.jpg" },

               new Product() { Id = 11, Name = "Samsung", Price = 354.0, SubCategoryId = 2,Path="img/plansetler_Samsung.jpg" },
               new Product() { Id = 12, Name = "Apple", Price = 354.0, SubCategoryId = 2 ,Path = "img/plansetler_Apple.jpg" },
               new Product() { Id = 13, Name = "Huawei", Price = 354.0, SubCategoryId = 2, Path = "img/plansetler_Huawei.jpg" },
               new Product() { Id = 14, Name = "Lenovo", Price = 100.40, SubCategoryId = 2 , Path = "img/plansetler_Lenovo.jpg" },
               new Product() { Id = 15, Name = "Acer", Price = 354.0, SubCategoryId = 2 , Path = "img/plansetler_Acer.jpg" },
               new Product() { Id = 16, Name = "Texet", Price = 354.0, SubCategoryId = 2 , Path = "img/plansetler_Texet.jpg" },
               new Product() { Id = 17, Name = "Wexler", Price = 354.0, SubCategoryId = 2 , Path = "img/plansetler_Wexler.jpg" },
               new Product() { Id = 18, Name = "i-Life", Price = 354.0, SubCategoryId = 2, Path = "img/plansetler_i-Life.jpg" },
               new Product() { Id = 19, Name = "MobiWinTab", Price = 354.0, SubCategoryId = 2 , Path = "img/plansetler_MobiWinTab.jpg" },
               new Product() { Id = 20, Name = "BQ", Price = 354.0, SubCategoryId = 2 , Path = "img/plansetler_BQ.jpg" },
               new Product() { Id = 21, Name = "Xiaomi", Price = 354.0, SubCategoryId = 2 , Path = "img/plansetler_Xiaomi.jpg" },
               new Product() { Id = 22, Name = "Micromax", Price = 354.0, SubCategoryId = 2 , Path = "img/plansetler_Micromax.jpg" },

               new Product() { Id = 23, Name = "Panasonic", Price = 354.0, SubCategoryId = 3 ,Path = "img/ev_telefonlari_Panasonic.jpg" },
               new Product() { Id = 24, Name = "Gigaset", Price = 354.0, SubCategoryId = 3 , Path = "img/ev_telefonlari_Gigaset.jpg" },

               new Product() { Id = 25, Name = "Qulaqliq qablari", Price = 354.0, SubCategoryId = 5 ,Path= "img/telefon_aksesuarlari_qulaqliq_qabi.jpg" },
                new Product() { Id = 26, Name = "Telefon ucun tutacaq", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_qulaqliq_qabi.jpg" },
               new Product() { Id = 27, Name = "Planset ucun qelem", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_planset_qelem.jpg" },
                new Product() { Id = 28, Name = "Powerbanklar", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_powerbank.jpg" },
               new Product() { Id = 29, Name = "Qulaqliqlar", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_qulaqliq.jpg" },
                new Product() { Id = 30, Name = "Selfi cubuqlari", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_selfi.jpg" },
               new Product() { Id = 31, Name = "Qoruyucu ortuk", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_qoruucu_otruk.jpg" },
                new Product() { Id = 32, Name = "Qoruyucu suse", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_qoruyucu_suse.jpg" },
               new Product() { Id = 33, Name = "Adapterler", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_adapter.jpg" },
                new Product() { Id = 34, Name = "Enerji toplayici naqiller", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_enerji_toplayici_naqil.jpg" },
               new Product() { Id = 35, Name = "Micro SD kart", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_microcard.jpg" },
                new Product() { Id = 36, Name = "Qulaliqlar(Bluetooth)", Price = 354.0, SubCategoryId = 5, Path = "img/telefon_aksesuarlari_qulaqliq_bluetooth.jpg" },

              
              
               new Product() { Id = 39, Name = "Huawei", Price = 354.0, SubCategoryId = 6, Path = "img/smartsaat_huawei.jpg" },
               new Product() { Id = 40, Name = "MYKoronoz", Price = 354.0, SubCategoryId = 6, Path = "img/smartsaat_mykronoz.jpg" },
               new Product() { Id = 41, Name = "Samsung", Price = 354.0, SubCategoryId = 6, Path = "img/smartsaat_samsung.jpg" },
                new Product() { Id = 42, Name = "Xiaomi", Price = 100.40, SubCategoryId = 6, Path = "img/smartsaat_xiaomi.jpg" },
               new Product() { Id = 43, Name = "Wonlex", Price = 354.0, SubCategoryId = 6, Path = "img/smartsaat_wonlex.jpg" },
               new Product() { Id = 44, Name = "Elari", Price = 354.0, SubCategoryId = 6, Path = "img/smartsaat_elari.jpg" },

               new Product() { Id = 45, Name = "Samsung", Price = 354.0, SubCategoryId = 7, Path = "img/smartsaat_elari.jpg" },
                new Product() { Id = 46, Name = "Xiaomi", Price = 100.40, SubCategoryId = 7, Path = "img/smartqolbaq_xiaomi.jpg" },
               new Product() { Id = 47, Name = "Huawei", Price = 354.0, SubCategoryId = 7, Path = "img/smartqolbaq_huawei.jpg" },
               new Product() { Id = 48, Name = "MyKronoz", Price = 354.0, SubCategoryId = 7, Path = "img/smartqolbaq_mykronoz.jpg" },

               new Product() { Id = 49, Name = "Casio", Price = 354.0, SubCategoryId = 8, Path = "img/saat_casio.jpg" },
               new Product() { Id = 50, Name = "Edifice", Price = 354.0, SubCategoryId = 8, Path = "img/saat_edifice.jpg" },
               new Product() { Id = 51, Name = "G-Shock", Price = 354.0, SubCategoryId = 8, Path = "img/saat_g-shock.jpg" },
               new Product() { Id = 52, Name = "Baby-G", Price = 354.0, SubCategoryId = 8, Path = "img/saat_baby-g.jpg" },

               new Product() { Id = 53, Name = "Apple Band", Price = 354.0, SubCategoryId = 9, Path = "img/saat_aksesuar_appleband.jpg" },

               new Product() { Id = 54, Name = "4K", Price = 354.0, SubCategoryId = 10, Path = "img/televizor_4k.jpg" },
               new Product() { Id = 55, Name = "LED", Price = 354.0, SubCategoryId = 10, Path = "img/televizor_led.jpg" },
               new Product() { Id = 56, Name = "QLED", Price = 354.0, SubCategoryId = 10, Path = "img/televizor_qled .jpg" },
               new Product() { Id = 57, Name = "8K", Price = 354.0, SubCategoryId = 10, Path = "img/televizor_8k.jpg" },
               new Product() { Id = 58, Name = "TRILUMINOS", Price = 354.0, SubCategoryId = 10, Path = "img/televizor_triluminos.jpg" },
               new Product() { Id = 59, Name = "NanoCell", Price = 354.0, SubCategoryId = 10, Path = "img/televizor_nanoled.jpg" },
            

               new Product() { Id = 61, Name = "Kinoteatr", Price = 354.0, SubCategoryId = 11, Path = "img/audio_kinoteatr.jpg" },
               new Product() { Id = 62, Name = "Smart TV Box", Price = 354.0, SubCategoryId = 11, Path = "img/audio_smarttvbox.jpg" },
               new Product() { Id = 63, Name = "Soundbar", Price = 354.0, SubCategoryId = 11, Path = "img/audio_saundbar.jpg" },
               new Product() { Id = 64, Name = "Portativ akustika", Price = 354.0, SubCategoryId = 11, Path = "img/audio_portativakustika.jpg" },
               new Product() { Id = 65, Name = "Musiqi merkezi", Price = 354.0, SubCategoryId = 11, Path = "img/audio_musiqimerkezi.jpg" },

               new Product() { Id = 66, Name = "Cercive", Price = 354.0, SubCategoryId = 13, Path = "img/tv_aksesuar_cercive.jpg" },
               new Product() { Id = 67, Name = "Sebeke birlesdiricileri", Price = 354.0, SubCategoryId = 13, Path = "img/tv_aksesuar_sebekebirlesdirici.jpg" },
               new Product() { Id = 68, Name = "HDMI naqil", Price = 354.0, SubCategoryId = 13, Path = "img/tv_aksesuar_hdmi.jpg" },
               new Product() { Id = 69, Name = "Asqi aparatlari", Price = 354.0, SubCategoryId = 13, Path = "img/tv_aksesuar_asqi.jpg" },

               new Product() { Id = 70, Name = "Router", Price = 354.0, SubCategoryId = 18, Path = "img/komputer_wifi_router.jpg" },
               new Product() { Id = 71, Name = "Modem", Price = 354.0, SubCategoryId = 18, Path = "img/komputer_wifi_modem.jpg" },
               new Product() { Id = 72, Name = "Guclendirici", Price = 354.0, SubCategoryId = 18, Path = "img/komputer_wifi_guclendirici.jpg" },
               new Product() { Id = 73, Name = "USB WI-FI adapter", Price = 354.0, SubCategoryId = 18, Path = "img/komputer_wifi_wifiadapter.jpg" },

               new Product() { Id = 74, Name = "Macbook", Price = 354.0, SubCategoryId = 20, Path = "img/komputer_apple_macbook.jpg" },
               new Product() { Id = 75, Name = "IMac", Price = 354.0, SubCategoryId = 20, Path = "img/komputer_apple_imac.jpg" },

               new Product() { Id = 76, Name = "DVD oxuyucu", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_dvd.jpg" },
  
               new Product() { Id = 78, Name = "Kartic", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_katric.jpg" },
               new Product() { Id = 79, Name = "Sebeke birlesdiricileri", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_sebekebirlesdirici.jpg" },
               new Product() { Id = 80, Name = "UPS", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_ups.jpg" },
               new Product() { Id = 81, Name = "Mousepad", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_mousepad.jpg" },
               new Product() { Id = 82, Name = "Ses guclendirici", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_sesguclendirici.jpg" },
               new Product() { Id = 83, Name = "Mouse", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_mouse.jpg" },
               new Product() { Id = 84, Name = "Klaviatura", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_klaviatura.jpg" },
               new Product() { Id = 85, Name = "Soyutma sistemi", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_soyutmasistemi.jpg" },
               new Product() { Id = 86, Name = "Temizlik vasiteleri", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_temizlik.jpg" },
               new Product() { Id = 87, Name = "Noutbuk ucun cantalar", Price = 354.0, SubCategoryId = 21, Path = "img/komputer_aksesuar_canta.jpg" },

               new Product() { Id = 88, Name = "Xarici toplayıcılar (HDD/SSD)", Price = 354.0, SubCategoryId = 23, Path = "img/komputer_yaddas_hdd_ssd.jpg" },
               new Product() { Id = 89, Name = "USB toplayici", Price = 354.0, SubCategoryId = 23, Path = "img/komputer_yaddas_usb.jpg" },
               new Product() { Id = 90, Name = "SD kart", Price = 354.0, SubCategoryId = 23, Path = "img/komputer_yaddas_sd.jpg" },

               new Product() { Id = 91, Name = "Linzalar", Price = 354.0, SubCategoryId = 27, Path = "img/foto_linzalar.jpg" },
               new Product() { Id = 92, Name = "Fotoaparatlar ucun cantalar", Price = 354.0, SubCategoryId = 27, Path = "img/foto_canta.jpg" },
               new Product() { Id = 93, Name = "CF kart", Price = 354.0, SubCategoryId = 27, Path = "img/foto_cfkart.jpg" },
               new Product() { Id = 94, Name = "Batareyalar", Price = 354.0, SubCategoryId = 27, Path = "img/foto_batareya.jpg" },
               new Product() { Id = 95, Name = "Stativler", Price = 354.0, SubCategoryId = 27, Path = "img/foto_stativ.jpg" },

               new Product() { Id = 96, Name = "Elektrosamokat", Price = 354.0, SubCategoryId = 29, Path = "img/oyun_neqliyat_elektrosamokat.jpg" },
               new Product() { Id = 97, Name = "Velosipedler", Price = 354.0, SubCategoryId = 29, Path = "img/oyun_neqliyat_velsiped.jpg" },
               new Product() { Id = 98, Name = "Segwat", Price = 354.0, SubCategoryId = 29, Path = "img/oyun_neqliyat_segway.jpg" },

               new Product() { Id = 99, Name = "Playstation", Price = 354.0, SubCategoryId = 30, Path = "img/oyun_playstation.jpg" },
               new Product() { Id = 100, Name = "Jostick", Price = 354.0, SubCategoryId = 30, Path = "img/oyun_playstation_joystick.jpg" },
               new Product() { Id = 101, Name = "Virtual eynek", Price = 354.0, SubCategoryId = 30, Path = "img/oyun_playstation_virtualeynek.jpg" },
               new Product() { Id = 102, Name = "Sukan", Price = 354.0, SubCategoryId = 30, Path = "img/oyun_playstation_sukan.jpg" },
               new Product() { Id = 103, Name = "Oyunlar", Price = 354.0, SubCategoryId = 30, Path = "img/oyun_playstation_oyunlar.jpg" },

               new Product() { Id = 104, Name = "Elektromexaniki konstruktor", Price = 354.0, SubCategoryId = 32, Path = "img/oyun_elektromexaniki.jpg" },
               new Product() { Id = 105, Name = "Velosiped aksesuarlari", Price = 354.0, SubCategoryId = 32, Path = "img/oyun_velosiped_aksesuar.jpg" },

               new Product() { Id = 106, Name = "Avtoyuyucu", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_avtoyuyucu.jpg" },
               new Product() { Id = 107, Name = "Tozsoran", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_tozsoran.jpg" },
               new Product() { Id = 108, Name = "Utu", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_utu.jpg" },
               new Product() { Id = 109, Name = "Tikis masinlari", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_tikismasini.jpg" },
               new Product() { Id = 110, Name = "Lampalar", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_lampalar.jpg" },
               new Product() { Id = 111, Name = "Buxarli utu", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_buxarligenerator.jpg" },
               new Product() { Id = 112, Name = "Utu masasi", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_utumasasi.jpg" },
               new Product() { Id = 113, Name = "Paltarqurudan", Price = 354.0, SubCategoryId = 33, Path = "img/evkiciktexnika_paltarqurudan.jpg" },

           
               new Product() { Id = 115, Name = "Dondurma duzelden", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_dondurma.jpg" },
               new Product() { Id = 116, Name = "Qehve", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_qehve.jpg" },
      
               new Product() { Id = 118, Name = "Mikrodalgali soba", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_mikrodalga.jpg" },
   
               new Product() { Id = 120, Name = "Toster", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_toster.jpg" },
               new Product() { Id = 121, Name = "Blender", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_blender.jpg" },
  
               new Product() { Id = 123, Name = "Corek bisiren", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_corekbisiren.jpg" },
               new Product() { Id = 124, Name = "Sireceken", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_sireceken.jpg" },
               new Product() { Id = 125, Name = "Etceken", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_etceken.jpg" },
               new Product() { Id = 126, Name = "Mini soba", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_minisoba.jpg" },
   
               new Product() { Id = 128, Name = "Dograyici", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_dograyici.jpg" },
               new Product() { Id = 129, Name = "Izqara", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_izqara.jpg" },
               new Product() { Id = 130, Name = "Qehveuyuden", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_qehveuyuden.jpg" },
               new Product() { Id = 131, Name = "Buxarli bisirici", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_buxarlibirsirici.jpg" },
               new Product() { Id = 132, Name = "Kombayn", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_kombayn.jpg" },
               new Product() { Id = 133, Name = "Fritoz", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_fritoz.jpg" },
               new Product() { Id = 134, Name = "Su filtri", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_sufltir.jpg" },
  
               new Product() { Id = 136, Name = "Qehvebisiren ucun kapsul", Price = 354.0, SubCategoryId = 34, Path="img/kicikmeiset_qehvebisiren.jpg" },
               new Product() { Id = 137, Name = "Kabab bisiren", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_kabab.jpg" },
               new Product() { Id = 138, Name = "Induksiyali pilte", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_induksiyali.jpg" },
               new Product() { Id = 139, Name = "Qehvebisiren", Price = 354.0, SubCategoryId = 34, Path = "img/kicikmeiset_qehvebisiren.jpg" },

               new Product() { Id = 140, Name = "Multistayler", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_multistayler.jpg" },
               new Product() { Id = 141, Name = "Trimmer", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_trimmer.jpg" },
               new Product() { Id = 142, Name = "Epilyator", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_epilyator,jpg" },
               new Product() { Id = 143, Name = "Uz qirxan", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_uzqirxan.jpg" },
               new Product() { Id = 144, Name = "Menikur desti", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_manikur.jpg" },
               new Product() { Id = 145, Name = "Terezi", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_terezi.jpg" },
               new Product() { Id = 146, Name = "Tonometr", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_tonometr.jpg" },
               new Product() { Id = 147, Name = "Masajor aya ucun", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_masajor.jpg" },
               new Product() { Id = 148, Name = "Elektrik yorgan", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_elektrikyorgan.jpg" },
               new Product() { Id = 149, Name = "Termometr", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_termometr.jpg" },
               new Product() { Id = 150, Name = "Masajor", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_ayaqmasajor.jpg" },
               new Product() { Id = 151, Name = "Sacqirxan", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_sacqirxan.jpg" },
               new Product() { Id = 152, Name = "Fen(Hava)", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_fenhava.jpg" },
               new Product() { Id = 153, Name = "Fen(Masa)", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_fenmasa.jpg" },
               new Product() { Id = 154, Name = "Fen(Utu)", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_fenutu.jpg" },
               new Product() { Id = 155, Name = "Fen(Daraq)", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_fendaraq.jpg" },
               new Product() { Id = 156, Name = "Elektrik dis fircasi", Price = 354.0, SubCategoryId = 35, Path = "img/gozellik_disfircasi.jpg" },

               new Product() { Id = 157, Name = "Termos", Price = 354.0, SubCategoryId = 36, Path = "img/qabqacaq_termos.jpg" },
               new Product() { Id = 158, Name = "Tavalar", Price = 354.0, SubCategoryId = 36, Path = "img/qabqacaq_tava.jpg" },
               new Product() { Id = 159, Name = "Qazanlar", Price = 354.0, SubCategoryId = 36, Path = "img/qabqacaq_qazan.jpg" },
               new Product() { Id = 160, Name = "Qapaqlar", Price = 354.0, SubCategoryId = 36, Path = "img/qabqacaq_qapaq.jpg" },
               new Product() { Id = 161, Name = "Metbex desti", Price = 354.0, SubCategoryId = 36, Path = "img/qabqacaq_metbexdesti.jpg" },
               new Product() { Id = 162, Name = "Bicaq ve bicaq itileyenler", Price = 354.0, SubCategoryId = 36, Path = "img/qabqacaq_bicaq.jpg" },

               new Product() { Id = 163, Name = "Soyuducu", Price = 354.0, SubCategoryId = 37, Path = "img/soyuducu.jpg" },
               new Product() { Id = 164, Name = "Paltaryuyan", Price = 354.0, SubCategoryId = 37, Path = "img/paltaryuyan.jpg" },
               ////
               new Product() { Id = 165, Name = "Qabyuyan", Price = 354.0, SubCategoryId = 37, Path = "img/qabyuyan.jpg" },
               new Product() { Id = 166, Name = "Quruducu masin", Price = 354.0, SubCategoryId = 37, Path = "img/quruducumasin.jpg" },
               new Product() { Id = 167, Name = "Aspirator", Price = 354.0, SubCategoryId = 37, Path = "img/aspirator.jpg" },
               new Product() { Id = 168, Name = "Plite", Price = 354.0, SubCategoryId = 37, Path = "img/pilte.jpg" },
               new Product() { Id = 169, Name = "Soba", Price = 354.0, SubCategoryId = 37, Path = "img/soba.jpg" },
               new Product() { Id = 170, Name = "Solo soba", Price = 354.0, SubCategoryId = 37, Path = "img/solosoba.jpg" },
               new Product() { Id = 171, Name = "Dispenser", Price = 354.0, SubCategoryId = 37, Path = "img/dispenser.jpg" },
               new Product() { Id = 172, Name = "Dondurucu", Price = 354.0, SubCategoryId = 37, Path = "img/dondurucu.jpg" },
               new Product() { Id = 173, Name = "Stabilizator", Price = 354.0, SubCategoryId = 37, Path = "img/stabilizator.jpg" },
               new Product() { Id = 174, Name = "Geyim ucun buxar dolabi", Price = 354.0, SubCategoryId = 37, Path = "img/buxardolabi.jpg" },


               new Product() { Id = 175, Name = "Yag Radiatorlari", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_radiator.jpg" },
               new Product() { Id = 176, Name = "Kondisoner", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_kondisoner.jpg" },
               new Product() { Id = 177, Name = "Iqlim kompleksi", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_iqlimkompleksi.jpg" },
               new Product() { Id = 178, Name = "Kombi ve Radiatorlar", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_kombi.jpg" },
               new Product() { Id = 179, Name = "Su qizdirici kalonka", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_kalonka.jpg" },
               new Product() { Id = 180, Name = "Qaz kalonkasi", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_qazkalonka.jpg" },
               new Product() { Id = 181, Name = "Spiralli pec", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_pec.jpg" },
               new Product() { Id = 182, Name = "Konvertor", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_konvektor.jpg" },
               new Product() { Id = 183, Name = "Isidici", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_isidici.jpg" },
               new Product() { Id = 184, Name = "Hava nemlendirici", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_nemlendirici.jpg" },
               new Product() { Id = 185, Name = "Hava temizleyici", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_havatemizleyici.jpg" },
               new Product() { Id = 186, Name = "Ventilyator", Price = 354.0, SubCategoryId = 38, Path = "img/iqlim_vintilyator.jpg" },

               new Product() { Id = 187, Name = "Metbex texnikasi ucun aksesuarlar", Price = 354.0, SubCategoryId = 39, Path = "img/" },
               new Product() { Id = 188, Name = "Ev texnikasi ucun aksesuarlar", Price = 354.0, SubCategoryId = 38, Path = "img/" },
               new Product() { Id = 189, Name = "Temizlik ve yuyucu vasiteleri", Price = 354.0, SubCategoryId = 38, Path = "img/" },

               new Product() { Id = 190, Name = "Sintifon yorgan", Price = 354.0, SubCategoryId = 51, Path = "img/tekstil_yorgan_sintifon.jpg" },
               new Product() { Id = 191, Name = "Bambu yorgan", Price = 354.0, SubCategoryId = 51, Path = "img/tekstil_yorgan_bambu.jpg" },
               new Product() { Id = 192, Name = "Qaz tuku yorgan", Price = 354.0, SubCategoryId = 51, Path = "img/tekstil_yorgan_qaztuku.jpg" },

               new Product() { Id = 193, Name = "Sintifon yastiq", Price = 354.0, SubCategoryId = 52,Path= "img/tekstil_yastiq_sintifon.jpg" },
               new Product() { Id = 194, Name = "Bambu yastiq", Price = 354.0, SubCategoryId = 52, Path = "img/tekstil_yastiq_bambu.jpg" },
               new Product() { Id = 195, Name = "Qaz tuku yastiq", Price = 354.0, SubCategoryId = 52, Path = "img/tekstil_yastiq_qaztuku.jpg" },

               new Product() { Id = 196, Name = "Tek neferlik pike desti", Price = 354.0, SubCategoryId = 53, Path = "img/tekstil_pike_tek.jpg" },
               new Product() { Id = 197, Name = "Cut neferlik pike desti", Price = 354.0, SubCategoryId = 53, Path = "img/tekstil_pike_cut.jpg" },

               new Product() { Id = 198, Name = "Tek neferlik yataq desti", Price = 354.0, SubCategoryId = 54, Path = "img/tekstil_yataq_tek.jpg" },
               new Product() { Id = 199, Name = "Iki neferlik yataq desti", Price = 354.0, SubCategoryId = 54, Path = "img/tekstil_yataq_iki.jpg" },
               new Product() { Id = 200, Name = "Usaq yataq desti", Price = 354.0, SubCategoryId = 54, Path = "img/tekstil_yataq_usaq.jpg" },

               new Product() { Id = 201, Name = "Usaq edyali", Price = 354.0, SubCategoryId = 55, Path = "img/tekstil_edyal_usaq.jpg" },
               new Product() { Id = 202, Name = "Edyallar", Price = 354.0, SubCategoryId = 55, Path = "img/tekstil_edyal_edyal.jpg" },

               new Product() { Id = 203, Name = "Hamam desmali", Price = 354.0, SubCategoryId = 56, Path = "img/tekstil_desmal_hamam.jpg" },
               new Product() { Id = 204, Name = "Uz desmali", Price = 354.0, SubCategoryId = 56, Path = "img/tekstil_desmal_uz.jpg" },

               new Product() { Id = 205, Name = "Qadin hamam xalati", Price = 354.0, SubCategoryId = 57, Path = "img/tekstil_xalat_qadin.jpg" },
               new Product() { Id = 206, Name = "Kisi hamam xalati", Price = 354.0, SubCategoryId = 57, Path = "img/tekstil_xalat_kisi.jpg" },
               new Product() { Id = 207, Name = "Usaq hamam xalati", Price = 354.0, SubCategoryId = 57, Path = "img/tekstil_xalat_usaq.jpg" },

               new Product() { Id = 208, Name = "Yataq otruyu desti", Price = 354.0, SubCategoryId = 58, Path = "img/tekstil_yataqostuyu.jpg" },
               new Product() { Id = 209, Name = "Usaq yataq otruyu", Price = 354.0, SubCategoryId = 58, Path = "img/tekstil_yataqostuyu_usa.jpg" }

           );
            modelBuilder.Entity<SubCategory>().HasData(

               new SubCategory() { Id = 1, Name = "Mobil telefonlar", CategoryId = 1 },
               new SubCategory() { Id = 2, Name = "Plansetler", CategoryId = 1 },
               new SubCategory() { Id = 3, Name = "Ev ve ofis telefonlari", CategoryId = 1 },
               new SubCategory() { Id = 4, Name = "Elektron kitab", CategoryId = 1 },
                   new SubCategory() { Id = 5, Name = "Aksesuarlar", CategoryId = 1 },
               new SubCategory() { Id = 6, Name = "Smart saatlar", CategoryId = 2 },
               new SubCategory() { Id = 7, Name = "Smart qolbaqlar", CategoryId = 2 },
               new SubCategory() { Id = 8, Name = "Saatlar", CategoryId = 2 },
                new SubCategory() { Id = 9, Name = "Aksesuarlar", CategoryId = 2 },

               new SubCategory() { Id = 10, Name = "Televizor ve proyektorlar", CategoryId = 3},
                new SubCategory() { Id = 11, Name = "Audio,video", CategoryId = 3 },


                new SubCategory() { Id = 12, Name = "Televizor altligi", CategoryId = 3 },
                new SubCategory() { Id = 13, Name = "Aksesuarlar", CategoryId = 3 },
                new SubCategory() { Id = 14, Name = "Monoblok", CategoryId = 4 },
                new SubCategory() { Id = 15, Name = "Sistem bloklari", CategoryId = 4 },
                new SubCategory() { Id = 16, Name = "Notebook", CategoryId = 4 },
                new SubCategory() { Id = 17, Name = "Printer", CategoryId = 4 },
                new SubCategory() { Id = 18, Name = "Wifi ve Sebeke avadanliqlari", CategoryId = 4 },
                new SubCategory() { Id = 19, Name = "Monitor", CategoryId = 4 },
                new SubCategory() { Id = 20, Name = "Apple", CategoryId = 4 },
                new SubCategory() { Id = 21, Name = "Noutbook aksesuarlari", CategoryId = 4 },
                new SubCategory() { Id = 22, Name = "Proqram teminati", CategoryId = 4 },
                new SubCategory() { Id = 23, Name = "Yaddas", CategoryId = 4 },

                new SubCategory() { Id = 24, Name = "Anti cap fotoaparatlar", CategoryId = 5 },
                new SubCategory() { Id = 25, Name = "Videoqeydiyyatci", CategoryId = 5 },
                new SubCategory() { Id = 26, Name = "Pesekar fotoaparatlar", CategoryId = 5 },
                new SubCategory() { Id = 27, Name = "Foto aksesuar", CategoryId = 5 },
                new SubCategory() { Id = 28, Name = "Videokameralar", CategoryId = 5 },

                new SubCategory() { Id = 29, Name = "Neqliyyat", CategoryId = 6 },
                new SubCategory() { Id = 30, Name = "PlayStation Store", CategoryId = 6 },
                new SubCategory() { Id = 31, Name = "Oyun konsollari", CategoryId = 6 },
                new SubCategory() { Id = 32, Name = "Aksesuarlar", CategoryId = 6 },

                new SubCategory() { Id = 33, Name = "Ev üçün kiçik məişət texnikasi", CategoryId = 7 },
                new SubCategory() { Id = 34, Name = "Mətbəx üçün kiçik məişət texnikası", CategoryId = 7 },
                new SubCategory() { Id = 35, Name = "Gözəllik və sağlamlıq", CategoryId = 7 },
                new SubCategory() { Id = 36, Name = "Qab-qacaq", CategoryId = 7 },
                new SubCategory() { Id = 37, Name = "Böyük məişət texnikası", CategoryId = 7 },
                new SubCategory() { Id = 38, Name = "İqlim texnikası", CategoryId = 7 },
                new SubCategory() { Id = 39, Name = "Aksesuarlar", CategoryId = 7 },


                new SubCategory() { Id = 40, Name = "Qonaq mebeli", CategoryId = 8 },
                new SubCategory() { Id = 41, Name = "Uşaq mebeli", CategoryId = 8 },
                new SubCategory() { Id = 42, Name = "Yataq mebeli", CategoryId = 8 },
                new SubCategory() { Id = 43, Name = "Yumşaq mebellər", CategoryId = 8 },
                new SubCategory() { Id = 44, Name = "TV stendlər", CategoryId = 8 },
                new SubCategory() { Id = 45, Name = "Dəhliz dolabları", CategoryId = 8 },
                new SubCategory() { Id = 46, Name = "Jurnal masalar", CategoryId = 8 },
                new SubCategory() { Id = 47, Name = "Mətbəx masaları", CategoryId = 8 },
                new SubCategory() { Id = 48, Name = "Mətbəx stulları", CategoryId = 8 },
                new SubCategory() { Id = 49, Name = "Mətbəx mebeli", CategoryId = 8 },



                 new SubCategory() { Id = 50, Name = "Masa örtüyü", CategoryId = 9 },
                new SubCategory() { Id = 51, Name = "Yorğanlar", CategoryId = 9 },
                new SubCategory() { Id = 52, Name = "Yastıqlar", CategoryId = 9 },
                new SubCategory() { Id = 53, Name = "Pikə dəsti", CategoryId = 9 },
                new SubCategory() { Id = 54, Name = "Yataq dəsti", CategoryId = 9 },
                new SubCategory() { Id = 55, Name = "Ədyallar", CategoryId = 9 },
                new SubCategory() { Id = 56, Name = "Dəsmallar", CategoryId = 9 },
                new SubCategory() { Id = 57, Name = "Hamam xalatı", CategoryId = 9 },
                new SubCategory() { Id = 58, Name = "Yataq örtüyü / yataq dəsti", CategoryId = 9 },
                new SubCategory() { Id = 59, Name = "Hamam xalçası", CategoryId = 9 }
           );

            modelBuilder.Entity<Category>().HasData(
                new Category() {Id = 1, Name = "Telefon ve Plansetler"},
                new Category() { Id = 2, Name = "Saat ve qolbaqlar" },
                new Category() { Id = 3, Name = "Tv,audiove video" },
                new Category() { Id = 4, Name = "Komputer ve ofis avadanliqlari"},
                new Category() { Id = 5, Name = "Foto ve video"},
                new Category() { Id = 6, Name = "Oyun ve Eylence"},
                new Category() { Id = 7, Name = "Meiset texnikasi"},
                new Category() { Id = 8, Name = "Mebel"},
                new Category() { Id = 9, Name = "Tekstil"}
            );
        }
    }
}