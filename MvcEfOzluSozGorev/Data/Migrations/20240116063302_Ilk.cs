using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcEfOzluSozGorev.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OzluSozler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzluSozler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OzluSozler",
                columns: new[] { "Id", "Soz", "Yazar" },
                values: new object[,]
                {
                    { 1, "Doğa bize hiçbir şey vermez, sadece ödünç alırız.", "John Ruskin" },
                    { 2, "Büyük ruhlar, eleştirilere sessiz kalabilirler.", "Franz Kafka" },
                    { 3, "Bilgi insanı özgür kılar.", "Kofi Annan" },
                    { 4, "Hayatınızdaki her şey bir şekilde düzenlenmiştir.", "Jim Rohn" },
                    { 5, "İyi bir kitap, iyi bir arkadaştır.", "Ernest Hemingway" },
                    { 6, "Sabırlı ol. Her şeyin olgunlaşması zaman alır.", "Tolstoy" },
                    { 7, "Hayatta sadece bir kez yaşarsınız, ancak doğru yaparsanız bir kez yeter.", "Mae West" },
                    { 8, "Zeka gücün anahtarıdır.", "Platon" },
                    { 9, "Hayatta hiçbir şey tesadüf değildir.", "Walt Disney" },
                    { 10, "Gözler kalbin penceresidir.", "İngiliz Atasözü" },
                    { 11, "Zorluklar sadece güçlü insanlara gelir.", "Unknown" },
                    { 12, "Zaman, sabrı olan her şeyi iyileştirir.", "Kofi Annan" },
                    { 13, "Küçük şeylerde mutluluğu bulabilen insanlar, gerçek zenginlerdir.", "Unknown" },
                    { 14, "Her gün bir adım attığınızda, bir gün dağları geçersiniz.", "Unknown" },
                    { 15, "Hayatınızdaki en değerli şey, sizin için en çok zaman harcadığınızdır.", "Unknown" },
                    { 16, "Hata yapmıyorsanız, muhtemelen yeterince denemiyorsunuzdur.", "Unknown" },
                    { 17, "Başarı, elde edilenlerden daha fazla başarısızlık anlamına gelmez.", "Unknown" },
                    { 18, "Yapabildiğiniz her şeyi yaparsanız, muhtemelen çok küçük düşünüyorsunuzdur.", "Unknown" },
                    { 19, "Başarılı bir insan, başarısızlığa uğramaktan korkmayandır.", "Unknown" },
                    { 20, "Hayatta sadece bir kere yaşarsınız, ama eğer doğru yaparsanız bir kere yeterlidir.", "Unknown" },
                    { 21, "Dünyayı değiştirmek istiyorsanız, kendinizden başlayın.", "Mahatma Gandhi" },
                    { 22, "Hayat, bisiklet sürmeye benzer. Dengeyi sürdüğünüz sürece düşmezsiniz.", "Albert Einstein" },
                    { 23, "Her insan bir gülüşle dünyayı değiştirebilir. Siz de bir insan mısınız?", "Unknown" },
                    { 24, "Eğitim, geleceğin anahtarıdır.", "Malcolm X" },
                    { 25, "Bir şeyi istemek ve ona sahip olmak arasındaki fark, çalışmaktır.", "Unknown" },
                    { 26, "Dünyayı değiştirmek istiyorsanız, önce kendinizi değiştirin.", "Leo Tolstoy" },
                    { 27, "Hayal gücü, bilgiye kıyasla daha önemlidir.", "Albert Einstein" },
                    { 28, "Bir şeyi yapabiliyorsanız, yapmalısınız.", "Unknown" },
                    { 29, "Büyük şeyler küçük adımlarla başlar.", "Unknown" },
                    { 30, "Başarı için çalışmak, başarısız olmak için düşlemekten daha iyidir.", "Unknown" },
                    { 31, "Küçük bir gülümseme, dünyayı değiştirebilir.", "Unknown" },
                    { 32, "Hayatta başarılı olmak için, ilk önce başarılı olmuş insanların yaptıklarını taklit edin.", "Steve Jobs" },
                    { 33, "Hayatınızı kendiniz seçin, başkaları için yaşamayın.", "Unknown" },
                    { 34, "Daima bir öğrenci olun, asla bir usta olmayın.", "Unknown" },
                    { 35, "Büyük düşünmek, büyük başarılar getirir.", "Unknown" },
                    { 36, "Her başarı, bir deneme sonucudur.", "Unknown" },
                    { 37, "Bilgi güçtür.", "Francis Bacon" },
                    { 38, "Hayatta birçok şeyi değiştiremezsiniz, ancak tutumunuzu değiştirebilirsiniz.", "Unknown" },
                    { 39, "Geçmişi düşünmeyin, geleceği inşa edin.", "Unknown" },
                    { 40, "İyi bir lider olmak için önce iyi bir takım oyuncusu olmalısınız.", "John C. Maxwell" },
                    { 41, "Bir şeyi değiştiremezseniz, ona karşı değişin.", "Andy Warhol" },
                    { 42, "Mükemmel olmak, her zaman mükemmel bir performans sergilemek değildir.", "Unknown" },
                    { 43, "Başarı, bir dizi küçük çabadan doğar.", "Unknown" },
                    { 44, "Bir kapı kapanırsa, başka bir kapı açılır; ancak bazen o kadar uzun sürebilir ki, aradaki koridorde mahsur kalırsınız.", "Unknown" },
                    { 45, "Eğer herkes sizinle aynı fikirdeyse, muhtemelen yanlış bir şey yapıyorsunuzdur.", "Unknown" },
                    { 46, "Zor zamanlar, gerçek karakterinizi ortaya çıkarır.", "Unknown" },
                    { 47, "Kendine güven, başkalarının senin hakkında düşündüğünü umursamamaktır.", "Unknown" },
                    { 48, "Başkalarının başarısından korkmayın; öğrenin ve ilham alın.", "Unknown" },
                    { 49, "Çabucak unutulan, çabucak iyileşir.", "Unknown" },
                    { 50, "Sınırlarınızın ötesine geçin, orada büyüme gerçekleşir.", "Unknown" },
                    { 51, "Herkesin önünde gitmek, liderlik değildir. Gerçek lider, arkasında başkalarını bırakandır.", "John C. Maxwell" },
                    { 52, "Zor zamanlarda bile umutlu olun; çünkü o zamanlarda gerçek karakter ortaya çıkar.", "Unknown" },
                    { 53, "Değişim, yaşamın bir parçasıdır; gelişmeye direnmek, yaşamın bir kısmını kaçırmaktır.", "Unknown" },
                    { 54, "Eğitim, yaşamın anahtarıdır.", "Unknown" },
                    { 55, "Başarı, istediğin şeyi elde etmek; mutluluk, elde ettiğin şeyi sevmektir.", "Unknown" },
                    { 56, "Başkalarını değiştiremezsiniz, sadece kendinizi değiştirebilirsiniz.", "Unknown" },
                    { 57, "Daima bir öğrenci olun; hayatınız boyunca öğrenmekten vazgeçmeyin.", "Unknown" },
                    { 58, "Başarısızlık, başarıya giden bir basamaktır.", "Unknown" },
                    { 59, "Bir şeyi gerçekten istiyorsanız, nasıl yapılacağını bulacaksınız.", "Unknown" },
                    { 60, "Hayatınızı kendiniz seçin, başkaları için yaşamayın.", "Unknown" },
                    { 61, "Zamanın tadını çıkarın, çünkü geri alamazsınız.", "Unknown" },
                    { 62, "İyi bir karar, doğru zamanda alınan karardır.", "Unknown" },
                    { 63, "Herkes bir öğretmendir. Ne olması gerektiğinizi öğrenin ve öğretin.", "Unknown" },
                    { 64, "Gülümseme, insanların yaşamınız boyunca hatırlayacağı bir şeydir.", "Unknown" },
                    { 65, "Hayat, bir kez yaşanır, doğru yaşamak gerekir.", "Unknown" },
                    { 66, "Elinizdekiyle yetinin, ama hayalinizden vazgeçmeyin.", "Unknown" },
                    { 67, "Küçük şeylere önem verin, çünkü bir gün hatırlarsanız, aslında büyük şeylerdi.", "Unknown" },
                    { 68, "Zor zamanlar, gerçek gücünü ortaya çıkarır.", "Unknown" },
                    { 69, "Küçük adımlar, büyük başarılar getirir.", "Unknown" },
                    { 70, "Herkes hata yapar; önemli olan onlardan öğrenmektir.", "Unknown" },
                    { 71, "Başarı, yetenek ve çabanın birleşimidir.", "Unknown" },
                    { 72, "İyi bir lider, iyi bir dinleyicidir.", "Unknown" },
                    { 73, "Kendinizi olumlu şeylere odaklayın, olumlu şeyler sizi bulacaktır.", "Unknown" },
                    { 74, "Büyük başarılar, büyük riskler gerektirir.", "Unknown" },
                    { 75, "İyi bir kitap, bir arkadaştır.", "Unknown" },
                    { 76, "Küçük şeylerde mutluluk bulamıyorsanız, büyük şeylerde bulamazsınız.", "Unknown" },
                    { 77, "Hayatınızın amacını keşfedin ve ona odaklanın.", "Unknown" },
                    { 78, "Kendi hikayenizi yazın; başkaları sizin için yazmasın.", "Unknown" },
                    { 79, "İyi bir insan olmak, dünyada bir iz bırakmaktır.", "Unknown" },
                    { 80, "Bir şeyi yapamayacak kadar küçük olabilirsiniz, ancak onu yapabilecek kadar büyük de olabilirsiniz.", "Unknown" },
                    { 81, "Hayatta hiçbir şey için geç değildir.", "Unknown" },
                    { 82, "Küçük adımlar, büyük değişikliklere yol açabilir.", "Unknown" },
                    { 83, "Düşüncelerinizi gerçekleştirmek için harekete geçin.", "Unknown" },
                    { 84, "Başarı, bir dizi küçük çabadan doğar.", "Unknown" },
                    { 85, "Küçük şeylerde mutluluk bulamıyorsanız, büyük şeylerde bulamazsınız.", "Unknown" },
                    { 86, "En büyük zafer, kendini yenmektir.", "Unknown" },
                    { 87, "Mükemmel olma çabasında ol, mükemmel olmaya çalışma.", "Unknown" },
                    { 88, "Kendine güven, başkalarının senin hakkında ne düşündüğünü umursamamaktır.", "Unknown" },
                    { 89, "Zamanın tadını çıkarın, çünkü geri alamazsınız.", "Unknown" },
                    { 90, "Büyük düşünmek, büyük başarılar getirir.", "Unknown" },
                    { 91, "Hayatınızı yönlendirmenin en iyi yolu, onu kendiniz oluşturmaktır.", "Unknown" },
                    { 92, "Bir hedef belirleyin ve ardından ona ulaşmak için adım atın.", "Unknown" },
                    { 93, "Başarılı olmanın anahtarı, sabırlı ve azimli olmaktır.", "Unknown" },
                    { 94, "İyi bir fikir, başarılı bir eylemle buluştuğunda, harikalar yaratılır.", "Unknown" },
                    { 95, "Küçük şeylere önem verin, çünkü bazen en büyük mutluluklar orada gizlidir.", "Unknown" },
                    { 96, "Başarının arkasındaki sır, bir şeyleri başlatmaktır.", "Unknown" },
                    { 97, "Doğru zamanı bekleme, doğru zamanı yaratmaktır.", "Unknown" },
                    { 98, "Hayatınızdaki değerli anları hatırlayın, çünkü o anlar yaşamınızı değerli kılar.", "Unknown" },
                    { 99, "Başkalarına yardım etmek, gerçek mutluluğun anahtarıdır.", "Unknown" },
                    { 100, "Geleceği görmek için gözlerin yeter, sadece görmeyi bilmelisin.", "Albert Einstein" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OzluSozler");
        }
    }
}
