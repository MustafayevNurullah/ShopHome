using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopHome.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discount_Of_The_Days",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    SlidersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount_Of_The_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discount_Of_The_Days_Sliders_SlidersId",
                        column: x => x.SlidersId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fixed_Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    SlidersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixed_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fixed_Photos_Sliders_SlidersId",
                        column: x => x.SlidersId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Last_15_Solds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    SlidersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Last_15_Solds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Last_15_Solds_Sliders_SlidersId",
                        column: x => x.SlidersId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    SlidersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Sliders_SlidersId",
                        column: x => x.SlidersId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    SlidersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slider_Sliders_SlidersId",
                        column: x => x.SlidersId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Today_Is_Offers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    SlidersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Today_Is_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Today_Is_Offers_Sliders_SlidersId",
                        column: x => x.SlidersId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_SubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Telefon ve Plansetler" },
                    { 2, "Saat ve qolbaqlar" },
                    { 3, "Tv,audiove video" },
                    { 4, "Komputer ve ofis avadanliqlari" },
                    { 5, "Foto ve video" },
                    { 6, "Oyun ve Eylence" },
                    { 7, "Meiset texnikasi" },
                    { 8, "Mebel" },
                    { 9, "Tekstil" }
                });

            migrationBuilder.InsertData(
                table: "Fixed_Photos",
                columns: new[] { "Id", "Path", "SlidersId" },
                values: new object[,]
                {
                    { 2, "img/photo2.jpg", null },
                    { 1, "img/photo1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Name", "Path", "Price", "SlidersId" },
                values: new object[,]
                {
                    { 20, "Xiaomi", "img/Offer20.jpg", 159.30000000000001, null },
                    { 19, "Xiaomi", "img/Offer19.jpg", 159.30000000000001, null },
                    { 18, "Samsung", "img/Offer18.jpg", 129.30000000000001, null },
                    { 17, "Huawei", "img/Offer17.jpg", 137.30000000000001, null },
                    { 16, "Xiaomi", "img/Offer16.jpg", 159.30000000000001, null },
                    { 15, "Xiaomi", "img/Offer15.jpg", 159.30000000000001, null },
                    { 14, "Xiaomi", "img/Offer14.jpg", 159.30000000000001, null },
                    { 12, "Xiaomi", "img/Offer12.jpg", 159.30000000000001, null },
                    { 11, "Xiaomi", "img/Offer11.jpg", 159.30000000000001, null },
                    { 13, "Xiaomi", "img/Offer13.jpg", 159.30000000000001, null },
                    { 9, "Samsung", "img/Offer9.jpg", 129.30000000000001, null },
                    { 8, "Huawei", "img/Offer8.jpg", 137.30000000000001, null },
                    { 7, "Xiaomi", "img/Offer7.jpg", 159.30000000000001, null },
                    { 6, "Xiaomi", "img/Offer6.jpg", 159.30000000000001, null },
                    { 5, "Xiaomi", "img/Offer5.jpg", 159.30000000000001, null },
                    { 4, "Xiaomi", "img/Offer4.jpg", 159.30000000000001, null },
                    { 3, "Samsung", "img/Offer3.jpg", 129.30000000000001, null },
                    { 2, "Huawei", "img/Offer2.jpg", 137.30000000000001, null },
                    { 1, "Xiaomi", "img/Offer1.jpg", 159.30000000000001, null },
                    { 10, "Xiaomi", "img/Offer10.jpg", 159.30000000000001, null }
                });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "Id", "Path", "SlidersId" },
                values: new object[,]
                {
                    { 5, "img/slider5.jpg", null },
                    { 4, "img/slider4.jpg", null },
                    { 3, "img/slider3.jpg", null },
                    { 1, "img/slider1.jpg", null },
                    { 2, "img/slider2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Today_Is_Offers",
                columns: new[] { "Id", "Name", "Path", "Price", "SlidersId" },
                values: new object[,]
                {
                    { 9, "Xiaomi", "img/today_offer9.jpg", 332.69999999999999, null },
                    { 1, "Xiaomi", "img/today_offer1.jpg", 332.69999999999999, null },
                    { 2, "Lenovo", "img/today_offer2.jpg", 302.69999999999999, null },
                    { 3, "Samsung", "img/today_offer3.jpg", 222.90000000000001, null },
                    { 4, "Xiaomi", "img/today_offer4.jpg", 332.69999999999999, null },
                    { 5, "Xiaomi", "img/today_offer5.jpg", 332.69999999999999, null },
                    { 6, "Xiaomi", "img/today_offer6.jpg", 332.69999999999999, null },
                    { 7, "Xiaomi", "img/today_offer7.jpg", 332.69999999999999, null },
                    { 8, "Xiaomi", "img/today_offer8.jpg", 332.69999999999999, null },
                    { 10, "Xiaomi", "img/today_offer10.jpg", 332.69999999999999, null }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Mobil telefonlar" },
                    { 32, 6, "Aksesuarlar" },
                    { 33, 7, "Ev üçün kiçik məişət texnikasi" },
                    { 34, 7, "Mətbəx üçün kiçik məişət texnikası" },
                    { 35, 7, "Gözəllik və sağlamlıq" },
                    { 36, 7, "Qab-qacaq" },
                    { 37, 7, "Böyük məişət texnikası" },
                    { 38, 7, "İqlim texnikası" },
                    { 39, 7, "Aksesuarlar" },
                    { 40, 8, "Qonaq mebeli" },
                    { 41, 8, "Uşaq mebeli" },
                    { 42, 8, "Yataq mebeli" },
                    { 43, 8, "Yumşaq mebellər" },
                    { 31, 6, "Oyun konsollari" },
                    { 44, 8, "TV stendlər" },
                    { 46, 8, "Jurnal masalar" },
                    { 47, 8, "Mətbəx masaları" },
                    { 48, 8, "Mətbəx stulları" },
                    { 49, 8, "Mətbəx mebeli" },
                    { 50, 9, "Masa örtüyü" },
                    { 51, 9, "Yorğanlar" },
                    { 52, 9, "Yastıqlar" },
                    { 53, 9, "Pikə dəsti" },
                    { 54, 9, "Yataq dəsti" },
                    { 55, 9, "Ədyallar" },
                    { 56, 9, "Dəsmallar" },
                    { 57, 9, "Hamam xalatı" },
                    { 45, 8, "Dəhliz dolabları" },
                    { 58, 9, "Yataq örtüyü / yataq dəsti" },
                    { 30, 6, "PlayStation Store" },
                    { 28, 5, "Videokameralar" },
                    { 2, 1, "Plansetler" },
                    { 3, 1, "Ev ve ofis telefonlari" },
                    { 4, 1, "Elektron kitab" },
                    { 5, 1, "Aksesuarlar" },
                    { 6, 2, "Smart saatlar" },
                    { 7, 2, "Smart qolbaqlar" },
                    { 8, 2, "Saatlar" },
                    { 9, 2, "Aksesuarlar" },
                    { 10, 3, "Televizor ve proyektorlar" },
                    { 11, 3, "Audio,video" },
                    { 12, 3, "Televizor altligi" },
                    { 13, 3, "Aksesuarlar" },
                    { 29, 6, "Neqliyyat" },
                    { 14, 4, "Monoblok" },
                    { 16, 4, "Notebook" },
                    { 17, 4, "Printer" },
                    { 18, 4, "Wifi ve Sebeke avadanliqlari" },
                    { 19, 4, "Monitor" },
                    { 20, 4, "Apple" },
                    { 21, 4, "Noutbook aksesuarlari" },
                    { 22, 4, "Proqram teminati" },
                    { 23, 4, "Yaddas" },
                    { 24, 5, "Anti cap fotoaparatlar" },
                    { 25, 5, "Videoqeydiyyatci" },
                    { 26, 5, "Pesekar fotoaparatlar" },
                    { 27, 5, "Foto aksesuar" },
                    { 15, 4, "Sistem bloklari" },
                    { 59, 9, "Hamam xalçası" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Path", "Price", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "Apple", "img/telefonlar_Apple.jpg", 100.40000000000001, 1 },
                    { 137, "Kabab bisiren", "img/kicikmeiset_kabab.jpg", 354.0, 34 },
                    { 138, "Induksiyali pilte", "img/kicikmeiset_induksiyali.jpg", 354.0, 34 },
                    { 139, "Qehvebisiren", "img/kicikmeiset_qehvebisiren.jpg", 354.0, 34 },
                    { 140, "Multistayler", "img/gozellik_multistayler.jpg", 354.0, 35 },
                    { 141, "Trimmer", "img/gozellik_trimmer.jpg", 354.0, 35 },
                    { 142, "Epilyator", "img/gozellik_epilyator,jpg", 354.0, 35 },
                    { 143, "Uz qirxan", "img/gozellik_uzqirxan.jpg", 354.0, 35 },
                    { 144, "Menikur desti", "img/gozellik_manikur.jpg", 354.0, 35 },
                    { 145, "Terezi", "img/gozellik_terezi.jpg", 354.0, 35 },
                    { 146, "Tonometr", "img/gozellik_tonometr.jpg", 354.0, 35 },
                    { 147, "Masajor aya ucun", "img/gozellik_masajor.jpg", 354.0, 35 },
                    { 148, "Elektrik yorgan", "img/gozellik_elektrikyorgan.jpg", 354.0, 35 },
                    { 149, "Termometr", "img/gozellik_termometr.jpg", 354.0, 35 },
                    { 150, "Masajor", "img/gozellik_ayaqmasajor.jpg", 354.0, 35 },
                    { 151, "Sacqirxan", "img/gozellik_sacqirxan.jpg", 354.0, 35 },
                    { 152, "Fen(Hava)", "img/gozellik_fenhava.jpg", 354.0, 35 },
                    { 153, "Fen(Masa)", "img/gozellik_fenmasa.jpg", 354.0, 35 },
                    { 154, "Fen(Utu)", "img/gozellik_fenutu.jpg", 354.0, 35 },
                    { 155, "Fen(Daraq)", "img/gozellik_fendaraq.jpg", 354.0, 35 },
                    { 156, "Elektrik dis fircasi", "img/gozellik_disfircasi.jpg", 354.0, 35 },
                    { 157, "Termos", "img/qabqacaq_termos.jpg", 354.0, 36 },
                    { 136, "Qehvebisiren ucun kapsul", "img/kicikmeiset_qehvebisiren.jpg", 354.0, 34 },
                    { 158, "Tavalar", "img/qabqacaq_tava.jpg", 354.0, 36 },
                    { 134, "Su filtri", "img/kicikmeiset_sufltir.jpg", 354.0, 34 },
                    { 132, "Kombayn", "img/kicikmeiset_kombayn.jpg", 354.0, 34 },
                    { 106, "Avtoyuyucu", "img/evkiciktexnika_avtoyuyucu.jpg", 354.0, 33 },
                    { 107, "Tozsoran", "img/evkiciktexnika_tozsoran.jpg", 354.0, 33 },
                    { 108, "Utu", "img/evkiciktexnika_utu.jpg", 354.0, 33 },
                    { 109, "Tikis masinlari", "img/evkiciktexnika_tikismasini.jpg", 354.0, 33 },
                    { 110, "Lampalar", "img/evkiciktexnika_lampalar.jpg", 354.0, 33 },
                    { 111, "Buxarli utu", "img/evkiciktexnika_buxarligenerator.jpg", 354.0, 33 },
                    { 112, "Utu masasi", "img/evkiciktexnika_utumasasi.jpg", 354.0, 33 },
                    { 113, "Paltarqurudan", "img/evkiciktexnika_paltarqurudan.jpg", 354.0, 33 },
                    { 115, "Dondurma duzelden", "img/kicikmeiset_dondurma.jpg", 354.0, 34 },
                    { 116, "Qehve", "img/kicikmeiset_qehve.jpg", 354.0, 34 },
                    { 118, "Mikrodalgali soba", "img/kicikmeiset_mikrodalga.jpg", 354.0, 34 },
                    { 120, "Toster", "img/kicikmeiset_toster.jpg", 354.0, 34 },
                    { 121, "Blender", "img/kicikmeiset_blender.jpg", 354.0, 34 },
                    { 123, "Corek bisiren", "img/kicikmeiset_corekbisiren.jpg", 354.0, 34 },
                    { 124, "Sireceken", "img/kicikmeiset_sireceken.jpg", 354.0, 34 },
                    { 125, "Etceken", "img/kicikmeiset_etceken.jpg", 354.0, 34 },
                    { 126, "Mini soba", "img/kicikmeiset_minisoba.jpg", 354.0, 34 },
                    { 128, "Dograyici", "img/kicikmeiset_dograyici.jpg", 354.0, 34 },
                    { 129, "Izqara", "img/kicikmeiset_izqara.jpg", 354.0, 34 },
                    { 130, "Qehveuyuden", "img/kicikmeiset_qehveuyuden.jpg", 354.0, 34 },
                    { 131, "Buxarli bisirici", "img/kicikmeiset_buxarlibirsirici.jpg", 354.0, 34 },
                    { 133, "Fritoz", "img/kicikmeiset_fritoz.jpg", 354.0, 34 },
                    { 105, "Velosiped aksesuarlari", "img/oyun_velosiped_aksesuar.jpg", 354.0, 32 },
                    { 159, "Qazanlar", "img/qabqacaq_qazan.jpg", 354.0, 36 },
                    { 161, "Metbex desti", "img/qabqacaq_metbexdesti.jpg", 354.0, 36 },
                    { 188, "Ev texnikasi ucun aksesuarlar", "img/", 354.0, 38 },
                    { 189, "Temizlik ve yuyucu vasiteleri", "img/", 354.0, 38 },
                    { 187, "Metbex texnikasi ucun aksesuarlar", "img/", 354.0, 39 },
                    { 190, "Sintifon yorgan", "img/tekstil_yorgan_sintifon.jpg", 354.0, 51 },
                    { 191, "Bambu yorgan", "img/tekstil_yorgan_bambu.jpg", 354.0, 51 },
                    { 192, "Qaz tuku yorgan", "img/tekstil_yorgan_qaztuku.jpg", 354.0, 51 },
                    { 193, "Sintifon yastiq", "img/tekstil_yastiq_sintifon.jpg", 354.0, 52 },
                    { 194, "Bambu yastiq", "img/tekstil_yastiq_bambu.jpg", 354.0, 52 },
                    { 195, "Qaz tuku yastiq", "img/tekstil_yastiq_qaztuku.jpg", 354.0, 52 },
                    { 196, "Tek neferlik pike desti", "img/tekstil_pike_tek.jpg", 354.0, 53 },
                    { 197, "Cut neferlik pike desti", "img/tekstil_pike_cut.jpg", 354.0, 53 },
                    { 198, "Tek neferlik yataq desti", "img/tekstil_yataq_tek.jpg", 354.0, 54 },
                    { 199, "Iki neferlik yataq desti", "img/tekstil_yataq_iki.jpg", 354.0, 54 },
                    { 200, "Usaq yataq desti", "img/tekstil_yataq_usaq.jpg", 354.0, 54 },
                    { 201, "Usaq edyali", "img/tekstil_edyal_usaq.jpg", 354.0, 55 },
                    { 202, "Edyallar", "img/tekstil_edyal_edyal.jpg", 354.0, 55 },
                    { 203, "Hamam desmali", "img/tekstil_desmal_hamam.jpg", 354.0, 56 },
                    { 204, "Uz desmali", "img/tekstil_desmal_uz.jpg", 354.0, 56 },
                    { 205, "Qadin hamam xalati", "img/tekstil_xalat_qadin.jpg", 354.0, 57 },
                    { 206, "Kisi hamam xalati", "img/tekstil_xalat_kisi.jpg", 354.0, 57 },
                    { 207, "Usaq hamam xalati", "img/tekstil_xalat_usaq.jpg", 354.0, 57 },
                    { 186, "Ventilyator", "img/iqlim_vintilyator.jpg", 354.0, 38 },
                    { 160, "Qapaqlar", "img/qabqacaq_qapaq.jpg", 354.0, 36 },
                    { 185, "Hava temizleyici", "img/iqlim_havatemizleyici.jpg", 354.0, 38 },
                    { 183, "Isidici", "img/iqlim_isidici.jpg", 354.0, 38 },
                    { 162, "Bicaq ve bicaq itileyenler", "img/qabqacaq_bicaq.jpg", 354.0, 36 },
                    { 163, "Soyuducu", "img/soyuducu.jpg", 354.0, 37 },
                    { 164, "Paltaryuyan", "img/paltaryuyan.jpg", 354.0, 37 },
                    { 165, "Qabyuyan", "img/qabyuyan.jpg", 354.0, 37 },
                    { 166, "Quruducu masin", "img/quruducumasin.jpg", 354.0, 37 },
                    { 167, "Aspirator", "img/aspirator.jpg", 354.0, 37 },
                    { 168, "Plite", "img/pilte.jpg", 354.0, 37 },
                    { 169, "Soba", "img/soba.jpg", 354.0, 37 },
                    { 170, "Solo soba", "img/solosoba.jpg", 354.0, 37 },
                    { 171, "Dispenser", "img/dispenser.jpg", 354.0, 37 },
                    { 172, "Dondurucu", "img/dondurucu.jpg", 354.0, 37 },
                    { 173, "Stabilizator", "img/stabilizator.jpg", 354.0, 37 },
                    { 174, "Geyim ucun buxar dolabi", "img/buxardolabi.jpg", 354.0, 37 },
                    { 175, "Yag Radiatorlari", "img/iqlim_radiator.jpg", 354.0, 38 },
                    { 176, "Kondisoner", "img/iqlim_kondisoner.jpg", 354.0, 38 },
                    { 177, "Iqlim kompleksi", "img/iqlim_iqlimkompleksi.jpg", 354.0, 38 },
                    { 178, "Kombi ve Radiatorlar", "img/iqlim_kombi.jpg", 354.0, 38 },
                    { 179, "Su qizdirici kalonka", "img/iqlim_kalonka.jpg", 354.0, 38 },
                    { 180, "Qaz kalonkasi", "img/iqlim_qazkalonka.jpg", 354.0, 38 },
                    { 181, "Spiralli pec", "img/iqlim_pec.jpg", 354.0, 38 },
                    { 182, "Konvertor", "img/iqlim_konvektor.jpg", 354.0, 38 },
                    { 184, "Hava nemlendirici", "img/iqlim_nemlendirici.jpg", 354.0, 38 },
                    { 208, "Yataq otruyu desti", "img/tekstil_yataqostuyu.jpg", 354.0, 58 },
                    { 104, "Elektromexaniki konstruktor", "img/oyun_elektromexaniki.jpg", 354.0, 32 },
                    { 102, "Sukan", "img/oyun_playstation_sukan.jpg", 354.0, 30 },
                    { 27, "Planset ucun qelem", "img/telefon_aksesuarlari_planset_qelem.jpg", 354.0, 5 },
                    { 28, "Powerbanklar", "img/telefon_aksesuarlari_powerbank.jpg", 354.0, 5 },
                    { 29, "Qulaqliqlar", "img/telefon_aksesuarlari_qulaqliq.jpg", 354.0, 5 },
                    { 30, "Selfi cubuqlari", "img/telefon_aksesuarlari_selfi.jpg", 354.0, 5 },
                    { 31, "Qoruyucu ortuk", "img/telefon_aksesuarlari_qoruucu_otruk.jpg", 354.0, 5 },
                    { 32, "Qoruyucu suse", "img/telefon_aksesuarlari_qoruyucu_suse.jpg", 354.0, 5 },
                    { 33, "Adapterler", "img/telefon_aksesuarlari_adapter.jpg", 354.0, 5 },
                    { 34, "Enerji toplayici naqiller", "img/telefon_aksesuarlari_enerji_toplayici_naqil.jpg", 354.0, 5 },
                    { 35, "Micro SD kart", "img/telefon_aksesuarlari_microcard.jpg", 354.0, 5 },
                    { 36, "Qulaliqlar(Bluetooth)", "img/telefon_aksesuarlari_qulaqliq_bluetooth.jpg", 354.0, 5 },
                    { 39, "Huawei", "img/smartsaat_huawei.jpg", 354.0, 6 },
                    { 40, "MYKoronoz", "img/smartsaat_mykronoz.jpg", 354.0, 6 },
                    { 41, "Samsung", "img/smartsaat_samsung.jpg", 354.0, 6 },
                    { 42, "Xiaomi", "img/smartsaat_xiaomi.jpg", 100.40000000000001, 6 },
                    { 43, "Wonlex", "img/smartsaat_wonlex.jpg", 354.0, 6 },
                    { 44, "Elari", "img/smartsaat_elari.jpg", 354.0, 6 },
                    { 45, "Samsung", "img/smartsaat_elari.jpg", 354.0, 7 },
                    { 46, "Xiaomi", "img/smartqolbaq_xiaomi.jpg", 100.40000000000001, 7 },
                    { 47, "Huawei", "img/smartqolbaq_huawei.jpg", 354.0, 7 },
                    { 48, "MyKronoz", "img/smartqolbaq_mykronoz.jpg", 354.0, 7 },
                    { 49, "Casio", "img/saat_casio.jpg", 354.0, 8 },
                    { 26, "Telefon ucun tutacaq", "img/telefon_aksesuarlari_qulaqliq_qabi.jpg", 354.0, 5 },
                    { 50, "Edifice", "img/saat_edifice.jpg", 354.0, 8 },
                    { 25, "Qulaqliq qablari", "img/telefon_aksesuarlari_qulaqliq_qabi.jpg", 354.0, 5 },
                    { 23, "Panasonic", "img/ev_telefonlari_Panasonic.jpg", 354.0, 3 },
                    { 2, "Samsung", "img/telefonlar_Samsung.jpg", 354.0, 1 },
                    { 3, "Xiaomi", "img/telefonlar_Xiaomi.jpg", 425.0, 1 },
                    { 4, "Huawei", "img/telefonlar_Huawei.jpg", 432.0, 1 },
                    { 5, "BQ", "img/telefonlar_BQ.jpg", 500.0, 1 },
                    { 6, "Honor", "img/telefonlar_Honor.jpg", 354.0, 1 },
                    { 7, "OnePlus", "img/telefonlar_OnePLus.jpg", 354.0, 1 },
                    { 8, "Hoffmann", "img/telefonlar_Hoffmann.jpg", 354.0, 1 },
                    { 9, "Sony", "img/telefonlar_Sony.jpg", 354.0, 1 },
                    { 10, "Nokia", "img/telefonlar_Nokia.jpg", 354.0, 1 },
                    { 11, "Samsung", "img/plansetler_Samsung.jpg", 354.0, 2 },
                    { 12, "Apple", "img/plansetler_Apple.jpg", 354.0, 2 },
                    { 13, "Huawei", "img/plansetler_Huawei.jpg", 354.0, 2 },
                    { 14, "Lenovo", "img/plansetler_Lenovo.jpg", 100.40000000000001, 2 },
                    { 15, "Acer", "img/plansetler_Acer.jpg", 354.0, 2 },
                    { 16, "Texet", "img/plansetler_Texet.jpg", 354.0, 2 },
                    { 17, "Wexler", "img/plansetler_Wexler.jpg", 354.0, 2 },
                    { 18, "i-Life", "img/plansetler_i-Life.jpg", 354.0, 2 },
                    { 19, "MobiWinTab", "img/plansetler_MobiWinTab.jpg", 354.0, 2 },
                    { 20, "BQ", "img/plansetler_BQ.jpg", 354.0, 2 },
                    { 21, "Xiaomi", "img/plansetler_Xiaomi.jpg", 354.0, 2 },
                    { 22, "Micromax", "img/plansetler_Micromax.jpg", 354.0, 2 },
                    { 24, "Gigaset", "img/ev_telefonlari_Gigaset.jpg", 354.0, 3 },
                    { 103, "Oyunlar", "img/oyun_playstation_oyunlar.jpg", 354.0, 30 },
                    { 51, "G-Shock", "img/saat_g-shock.jpg", 354.0, 8 },
                    { 53, "Apple Band", "img/saat_aksesuar_appleband.jpg", 354.0, 9 },
                    { 81, "Mousepad", "img/komputer_aksesuar_mousepad.jpg", 354.0, 21 },
                    { 82, "Ses guclendirici", "img/komputer_aksesuar_sesguclendirici.jpg", 354.0, 21 },
                    { 83, "Mouse", "img/komputer_aksesuar_mouse.jpg", 354.0, 21 },
                    { 84, "Klaviatura", "img/komputer_aksesuar_klaviatura.jpg", 354.0, 21 },
                    { 85, "Soyutma sistemi", "img/komputer_aksesuar_soyutmasistemi.jpg", 354.0, 21 },
                    { 86, "Temizlik vasiteleri", "img/komputer_aksesuar_temizlik.jpg", 354.0, 21 },
                    { 87, "Noutbuk ucun cantalar", "img/komputer_aksesuar_canta.jpg", 354.0, 21 },
                    { 88, "Xarici toplayıcılar (HDD/SSD)", "img/komputer_yaddas_hdd_ssd.jpg", 354.0, 23 },
                    { 89, "USB toplayici", "img/komputer_yaddas_usb.jpg", 354.0, 23 },
                    { 90, "SD kart", "img/komputer_yaddas_sd.jpg", 354.0, 23 },
                    { 91, "Linzalar", "img/foto_linzalar.jpg", 354.0, 27 },
                    { 92, "Fotoaparatlar ucun cantalar", "img/foto_canta.jpg", 354.0, 27 },
                    { 93, "CF kart", "img/foto_cfkart.jpg", 354.0, 27 },
                    { 94, "Batareyalar", "img/foto_batareya.jpg", 354.0, 27 },
                    { 95, "Stativler", "img/foto_stativ.jpg", 354.0, 27 },
                    { 96, "Elektrosamokat", "img/oyun_neqliyat_elektrosamokat.jpg", 354.0, 29 },
                    { 97, "Velosipedler", "img/oyun_neqliyat_velsiped.jpg", 354.0, 29 },
                    { 98, "Segwat", "img/oyun_neqliyat_segway.jpg", 354.0, 29 },
                    { 99, "Playstation", "img/oyun_playstation.jpg", 354.0, 30 },
                    { 100, "Jostick", "img/oyun_playstation_joystick.jpg", 354.0, 30 },
                    { 101, "Virtual eynek", "img/oyun_playstation_virtualeynek.jpg", 354.0, 30 },
                    { 80, "UPS", "img/komputer_aksesuar_ups.jpg", 354.0, 21 },
                    { 52, "Baby-G", "img/saat_baby-g.jpg", 354.0, 8 },
                    { 79, "Sebeke birlesdiricileri", "img/komputer_aksesuar_sebekebirlesdirici.jpg", 354.0, 21 },
                    { 76, "DVD oxuyucu", "img/komputer_aksesuar_dvd.jpg", 354.0, 21 },
                    { 54, "4K", "img/televizor_4k.jpg", 354.0, 10 },
                    { 55, "LED", "img/televizor_led.jpg", 354.0, 10 },
                    { 56, "QLED", "img/televizor_qled .jpg", 354.0, 10 },
                    { 57, "8K", "img/televizor_8k.jpg", 354.0, 10 },
                    { 58, "TRILUMINOS", "img/televizor_triluminos.jpg", 354.0, 10 },
                    { 59, "NanoCell", "img/televizor_nanoled.jpg", 354.0, 10 },
                    { 61, "Kinoteatr", "img/audio_kinoteatr.jpg", 354.0, 11 },
                    { 62, "Smart TV Box", "img/audio_smarttvbox.jpg", 354.0, 11 },
                    { 63, "Soundbar", "img/audio_saundbar.jpg", 354.0, 11 },
                    { 64, "Portativ akustika", "img/audio_portativakustika.jpg", 354.0, 11 },
                    { 65, "Musiqi merkezi", "img/audio_musiqimerkezi.jpg", 354.0, 11 },
                    { 66, "Cercive", "img/tv_aksesuar_cercive.jpg", 354.0, 13 },
                    { 67, "Sebeke birlesdiricileri", "img/tv_aksesuar_sebekebirlesdirici.jpg", 354.0, 13 },
                    { 68, "HDMI naqil", "img/tv_aksesuar_hdmi.jpg", 354.0, 13 },
                    { 69, "Asqi aparatlari", "img/tv_aksesuar_asqi.jpg", 354.0, 13 },
                    { 70, "Router", "img/komputer_wifi_router.jpg", 354.0, 18 },
                    { 71, "Modem", "img/komputer_wifi_modem.jpg", 354.0, 18 },
                    { 72, "Guclendirici", "img/komputer_wifi_guclendirici.jpg", 354.0, 18 },
                    { 73, "USB WI-FI adapter", "img/komputer_wifi_wifiadapter.jpg", 354.0, 18 },
                    { 74, "Macbook", "img/komputer_apple_macbook.jpg", 354.0, 20 },
                    { 75, "IMac", "img/komputer_apple_imac.jpg", 354.0, 20 },
                    { 78, "Kartic", "img/komputer_aksesuar_katric.jpg", 354.0, 21 },
                    { 209, "Usaq yataq otruyu", "img/tekstil_yataqostuyu_usa.jpg", 354.0, 58 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discount_Of_The_Days_SlidersId",
                table: "Discount_Of_The_Days",
                column: "SlidersId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixed_Photos_SlidersId",
                table: "Fixed_Photos",
                column: "SlidersId");

            migrationBuilder.CreateIndex(
                name: "IX_Last_15_Solds_SlidersId",
                table: "Last_15_Solds",
                column: "SlidersId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_SlidersId",
                table: "Offers",
                column: "SlidersId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Slider_SlidersId",
                table: "Slider",
                column: "SlidersId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Today_Is_Offers_SlidersId",
                table: "Today_Is_Offers",
                column: "SlidersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discount_Of_The_Days");

            migrationBuilder.DropTable(
                name: "Fixed_Photos");

            migrationBuilder.DropTable(
                name: "Last_15_Solds");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "Today_Is_Offers");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
