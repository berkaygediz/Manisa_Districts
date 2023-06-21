namespace Manisa_Districts
{
    internal class Program
    {
        class Ilce
        {
            //Bir sınıf oluşturarak boş bir iskelet yapısı oluşturdum. Bu iskelet yapısında ilçe ve nüfus bilgileri için yapı oluşturdum.
            public string Ilce_ad { get; set; }
            public int Nufus_sayi { get; set; }

            //İlçe adının programımın herhangi bir yerinden tanımlanabilir değişken bir yapı kurmak için public olarak belirledim.
            //Verilerin hem alınıp(get), hem de ayarlanabilir(set) olmasını kapsam dahiline aldım.

            public Ilce(string ilce, int nufus)
            {
                Ilce_ad = ilce;
                Nufus_sayi = nufus;

                //Program genelinde erişilebilir iki parametreli erişim metodu olan Ilce'yi tanımladım.
                //Yukarıda tanımladığım metin Ilce_ad ve tamsayı tipinde olan Nufus_sayi'yı parametrelerden gelecek verilerle eşledim.
            }
        }

        static void Main()
        {
        baslangic: //goto için gideceği etiketi belirledim.
            Random anektodrastgele = new Random(); //Random sınıfını tanımladım.
            int anektodindex = anektodrastgele.Next(0, 6); //Aşağıdaki 6 elemanlı dizideki verileri her program çalıştığında, rastgele index'le göstersin diye Random sınıfının Next metodunu kullandım.

            string[] anektod = {
                "\n Manisa ili; Osmanlı İmparatorluğu zamanında Saruhan Sancağı olarak idare yapısı içinde yer almış, \n 1923 yılında Cumhuriyetin ilanı ile birlikte Saruhan ili olarak teşkil edilmiş olup, \n müteakiben 1927 yılında isim değişikliği yapılarak Manisa adını almıştır.",
                "\n Spil Dağında yaşayan ve Manisa sokaklarında üzerinde sadece şort ile dolaşan Ahmet Bedevi'ye halk \n Manisa Tarzanı adını takmıştır. 1963 yılında hayatını kaybedince Manisa halkınca bir \n efsaneye dönüştürülmüş, heykeli dikilmiştir. Her yıl ölüm yıldönümü olan \n 31 Mayıs'da Manisa'da Ahmet Bedevi için törenler düzenlenir.",
                "\n Türkler Magnesia ismini Manisa olarak değiştirmişlerdir. Başka bir rivâyete göre Manisa civarında \n mıknatıslı demir olduğundan Manisa ismi mıknatıstan gelmektedir. Manisa'nın târihi, \n Truva Savaşlarından çok önceye, M.Ö. 3000 senelerine dayanır.",
                "\n Şifalı mesir macunu dışında Manisa'da tadılabilecek lezzetler arasında mesir çayı, Akhisar Köftesi, \n maden suyu, Manisa Kebabı, Alaşehir Kapaması, Salihli Odun Köftesi yer almaktadır.",
                "\n Manisa ilinin en önemli bitkisel ürünleri Kuru ve Yaş Üzüm, Zeytin, Kiraz, Tütün, Kurutmalık ve Yaş \n Domates, Mısır, Kavun ve Karpuzdur. ",
                "\n Manisa il topraklarının %46 sı orman ve makilerle kaplıdır. Geniş bir alanı kaplayan makiler dağların \n kuzey ve batı yamaçlarında yer alır. Ormanlar meşe, dişbudak, karaağaç, karaçam, \n kızılçam, ardıç, ahlât ve çınardan ibarettir. Ormanlar genelde 1000 metre \n üzerindeki yükseltilerde bulunur."
            }; //Bir metin dizisi tanımladım ve 6 tane veri ekledim. ters n ile yeni satıra atlattım.

            Ilce[] ilcekoleksiyon = {
                new Ilce("Ahmetli", 16530),
                new Ilce("Akhisar", 173026),
                new Ilce("Alaşehir", 105145),
                new Ilce("Demirci", 41135),
                new Ilce("Gölmarmara", 15247),
                new Ilce("Gördes", 28182),
                new Ilce("Kırkağaç", 38274),
                new Ilce("Köprübaşı", 13347),
                new Ilce("Kula", 44410),
                new Ilce("Salihli", 161562),
                new Ilce("Sarıgöl", 35957),
                new Ilce("Saruhanlı", 54660),
                new Ilce("Selendi", 20291),
                new Ilce("Soma", 108981),
                new Ilce("Şehzadeler", 167661),
                new Ilce("Turgutlu", 163223),
                new Ilce("Salihli", 257993)
            }; //Yukarıda tanımladığım ilçe sınıfı için ilcekoleksiyon'u oluşturdum ve sınıf içindeki public ilce erişim metoduyla tanımlamalar yaptım. ilce ve nufus parametrelerini girip bütün Manisa'nın ilçelerini tanımladım.

            Console.WriteLine("A N E K T O D:" + anektod[anektodindex] + "\n"); //Yukarıda oluşturduğum anektod dizisinden, rastgele oluşturulan oluşturulan sayılar ile rastgele dizi elemanına ulaşıyorum.

            string[] sabitilceler = { "Ahmetli", "Akhisar", "Alaşehir", "Demirci", "Gölmarmara", "Gördes", "Kırkağaç", "Köprübaşı", "Kula", "Salihli", "Sarıgöl", "Saruhanlı", "Selendi", "Soma", "Şehzadeler", "Turgutlu", "Yunusemre" };
            //Manisa'nın ilçelerini dizi elemanı olarak kullanmak istediğim için ilçe tanımlamaları yaptım.

            string[] bilgi = {
                "İlçenin halkı geçimini üzüm, pamuk, (kırmızı, tarhanalık, salçalık) biber, domates, \n tütün ve zeytin üretimi yaparak sağlar. Doğusunda Salihli, batısında Turgutlu bulunur. Ege Bölgesi'nin \n en verimli üzüm bağlarının Ahmetli ovasında olduğu \n belirtilmektedir. ",
                "Türkiye'nin Ege Bölgesi'nde bulunan Manisa iline bağlı bir ilçedir. Şehir merkezinde on dört, \n kırsalda doksan altı mahallesi bulunan Akhisar, 174.850 kişilik nüfusu ile Manisa'nın il \n merkezi dışında nüfusu en yüksek, Türkiye'nin ise yüz \notuz sekizinci nüfusu en yüksek ilçesidir. \n Orta Gediz Havzası'nda bulunan Akhisar Ovası üzerinde kuruludur. 1645 km²'lik yüzölçümü ile Manisa \n genelinde en fazla yüzölçümüne sahip ilçe konumundadır. İlçenin en önemli geçim kaynağı tarımdır. \n Tarım dışında hammaddeye dayalı sanayi ve ticaret ilçenin diğer ekonomik faaliyetlerindendir. \n İlçenin topraklarının %47'si tarım arazisi olarak kullanılırken bu arazilerde \n daha çok zeytin ve üzüm üretimi gerçekleştirilmektedir.",
                "İç Ege Bölgesi'nde, Batı Anadolu'daki doğu-batı yönlü ovalardan biri olan Gediz Ovası'nın doğu \n kesiminde bulunmaktadır. Yüzölçümü 977 km²'dir. İlçe ekonomisi tarım, hayvancılık ve \n sanayiye dayalıdır. Yetiştirilen başlıca tarımsal ürünler, \nüzüm başta olmak üzere, tütün, pamuk, \n tahıl, armut ve zeytindir. Hayvancılıkta sığır ve koyun yetiştirilir. İlçede ayrıca 150 üzüm ihracatı \n yapan firma, 80 üzüm işletmesi, Tariş Üzüm Entegre Tesisleri ve Suma Fabrikası ile Sarıkız Maden Suyu \n Fabrikası bulunmaktadır. ",
                "Yontma Taş Devri’nden bu yana yerleşim alanı olan bölgede, Hitit, Frig, Lidya, Pers, İskender, \n Bergama, Roma ve Bizans yönetimlerini yaşayan ilçe, Anadolu Beylikleri döneminde 1310 yılında \n Türk egemenliği altına girmiştir. 1412 yılına kadar \n Saruhanoğulları yönetiminde kalan Demirci, bu tarihte Osmanlı yönetimine dahil edilmiştir.",
                "Manisa ilinin en küçük ilçelerinden biridir. İsmini ilçe sınırları içerisinde bulunan Marmara \n Gölü'nden almaktadır. İlçe Ege Bölgesi'nin Kuzeybatı'sında yer alır. Batısında Saruhanlı ve Manisa Kuzeyinde, \n  Akhisar ve Gördes, Güney doğusunda \n Salihli, Güney batısında Ahmetli ve Turgutlu bulunmaktadır. İlçe, Marmara Dağı'nın eteğinde kurulsa da \n zamanla ovaya yayılmıştır.  ",
                "Sırasıyla Persler, Makedonyalılar, Roma İmparatorluğu ve Bizans İmparatorluklarının egemenliklerinde kalmış; \n 1071 Malazgirt Savaşı'ndan kısa bir süre sonra Türklerin eline geçmiştir. Selçuklu Devleti'nin yıkılmasından \n sonra Karesi Beyliği'nin sınırları içinde kalmıştır. 1641 yılında Gördes'ten geçen Evliya Çelebi'nin belirttiği gibi; \n Büyük İskender tarihinden sonra Yankoa Kralının Veledi Nakeplerinden Köritöz adlı kral'ın elinden Saruhanoğlu Yakuphan tarafından fethedilmiştir. \n Bedesti Ulaş Bey'e daha sonra Yakup Şah'ın Kızının nikâhı sonrasında çeyiz yoluyla Yıldırım \n Bayezid'ın eline, dolayısıyla Osmanlı İmparatorluğu topraklarına katılmıştır.\r\n\r\nGördes Türk Kurtuluş Savaşı sıralarında sürekli savaş sahası olmuş ve ilk defa 15 Temmuz 1920'de Yunan \n kuvvetleri tarafından istila edildikten sonra, 14 ay kadar Yunan işgalinde kalmış ve \n 5 Eylül 1922'de kurtarılmıştır.",
                "İlçe tarihine dair net bilgiler bulunmasa da çevrede yapılan kazılarda ilk yerleşimin Antik Yunan \n dönemindeki Mysialılara dayandığı öngörülmektedir. Beylikler döneminde Karesi Beyliği'ne \n bağlı olan ilçe daha sonra Osmanlı himayesine girmiştir.\r\n\r\n İlçe, Cumhuriyet'in ilanından sonra gerçekleştirilen Mübadele ile beraber Yunanistan'dan gelen mübadiller şehre yerleştirilmiştir. \n Özellikle Midilli, Drama'nın Pravişte kazasının Esirli, Paliohor, Dranova köyleri ile Selânik Avrethisar \n Paprat muhacirleri Kırkağaç'a iskan edilmiştir.  ",
                "İlçe civarında bulunan mağaralardaki insan yaşantısı belirtilerinden İlçe çevresinin bakır ve tunç \n devirlerini de yaşadıkları anlaşılmaktadır. Bölgede bulunan “Sidas Harabeleri” Frig, \n Lidya ve Pers İmparatorluklarına ait medeniyetlerin varlığına \n işaret etmektedir. Bazı tarihçilere göre Köprübaşı çevresinde Etiler'in hüküm sürdüğü kabul edilmektedir. Sonradan yöre Lidya, Pers, \n Bergama Krallığı ve Saruhanoğullarının egemenliğinde kalmıştır. M.Ö. 333 yılından itibaren Makedon Kralı \n Büyük İskender, M.Ö. 190 yılından sonra ise; Bizans (Doğu Roma) dönemlerini gören yöre, \n 1071 Malazgirt Zaferi’nden sonra 1074 yılından itibaren Türklerin egemenliğine \n girmiştir. 131O yılından sonra Anadolu Beylikleri’nin egemenliğine girmiştir. Saruhanoğlu Çuha Bey, \n onun ölümünden sonra oğlu Devlethan, onun ölümünden sonra da Yakup Çelebi yörenin hakimi olmuştur. \n Saruhanoğulları’nın hakimiyeti 1412 yılında son bulmasıyla 1920 yılına kadar Osmanlı egemenliğinde kalmıştır. \n Gediz Nehri üzerinde kurulan Demirköprü Barajının su tutmaya başlaması ve suyun hızla doğu istikametine \n ilerleyerek Borlu Nahiyesi topraklarını su altında bırakması sonucu, Borlu halkının bir kısmı 1958'den \n itibaren şu anki Köprübaşı İlçesinin kurulduğu yere yerleşmişlerdir. Esas yerleşim ise 1959 yılında olmuştur. \n O yıllarda şu anki demir köprünün yerinde iki gözlü beton bir köprü olduğu ve İlçenin adının buradan geldiği \n bilinmektedir. 1967 yılında Belediyelik olan Köprübaşı 20 Mayıs 1990 tarih ve 20523 sayılı Resmi Gazetede \n yayımlanan 3644 sayılı 130 ilçe kurulması hakkındaki kanun ile ilçe olarak 25 Ağustos 1991 tarihinden \n itibaren fiilen ilçe faaliyetlerine başlamıştır.",
                "Mimari, etnografik, arkeolojik, tarihi ve görsel değerleri ile Ege’nin ilçelerinden biridir. Bölgede \n yapılan kazılarda Katekekaumene (Yanık yöre) sınırı içinde Demir Köprü barajı \n yakınındaki Divlit’te ilkel insanın ayak izlerine rastlanılmıştır. \n Bunun yanı sıra yapılan kazılarda MÖ 56 yılına ait mermer kabartma ve kitabelerden Kula ve çevresinin önemli bir yerleşim alanı olduğu \n ortaya çıkmaktadır.\r\n\r\nEski dönemlerde Kula’nın civarında kurulmuş bulunan Maionia (Menye), Mysien \n ve Lidya arasında bir yerleşim alanı idi ve buradan geçen yol Sardes-Salihli’den başlar ve \n Menye-Sandal-Gölde üzerinden geçerdi. Kula’daki yerleşim zamanla civarındaki \n yerleşim alanlarının önemini yitirmesi sonucunda gelişmiştir. Kula’nın ismini burç manasında olan \n Kule'den almış olduğu belgelerden anlaşılmaktadır.\r\n\r\nKula’nın ismi hakkında pek çok araştırmacı \n inceleme yaptıkları halde kesin bir sonuca varılamamıştır. Bir söylentiye göre de havası suyu iyi ve şifalı \n olduğundan zengin bir kişinin hasta olan kızı için buraya bir kule yaptırdığı ve buranın zamanla \n gelişip bugünkü duruma geldiğinden bahsedilir. ",
                "Türkiye'nin Ege Bölgesi'nde bulunan Manisa'nın bir ilçesidir. Odun köftesi, kirazı ve üzümü ile meşhurdur. \n Tarihte ilk paranın basıldığı ve günümüzde UNESCO Dünya Mirası Geçici \n Listesi'ne giren Sardes antik kenti bu ilçede bulunmaktadır. İlçe,\n bölgenin tarih, doğa ve termal turizm bakımından en önemli merkezlerindendir.\r\n\r\nSalihli, tarihi, tarıma elverişli toprakları, termal \n enerjiye dayalı seraları, hızla gelişen Organize Sanayi Bölgesi, Manisa Celal Bayar Üniversitesi İktisadi \n ve İdari Bilimler Fakültesi ve turizm yatırımları ile öne çıkmaktadır. ",
                "Halk arasındaki rivayetlere göre ilçenin bu yerleşim alanı deniz seviyesinden alçakta bir göl imiş. \n Gerek ilçe çevresinde gerekse ilçenin köylerindeki ören yerleri çevre tarihçesinin \n çok eski olduğunu göstermektedir. Yazılı kitabelere \n rastlanmamakta birlikte Dadağlı köyü Alafakı mevkiinde (Han Çeşmesi) ve buradaki konaklama yerinin izleri (temel yıkıntıları) ve çevresindeki mezarlık \n buralarda milattan önceki bir medeniyetin var olduğunu göstermektedir.\r\n\r\nDindarlı köyünün Çarsak \n yöresinde yanmış bir köy kalıntıları ve bu köye ait Buldan yolu üzerindeki mezarlık \n (sonradan tarla haline getirilmiş) bu mezarlıktaki taşlarda bulunan Latince yazılar \n aynı köyün Kulu çeşmesi ve çevresindeki bina yıkıntıları burada bulunan bakır paralar, küpler, \n çeşitli testiler, buralarda İyonların veya Lidyalıların egemen olduğunu açıkça belirtmektedir. \n Emcelli köyü doğu kesiminde Süğmezli Çeşmesi ve çevresindeki bina kalıntıları, buradaki dört köşeli bir kuyu \n kalıntısı, kayalara oyulmuş deniz araçlarını bağlama yerleri, şimdiki ovanın göl olduğunun delilleridir.",
                "Saruhanlı’nın kesin kuruluş tarihi bilinmiyorsa da (1313-1437) Saruhan Beyliği döneminde kurulduğu \n düşünülmektedir.Bölgeye ilk yerleşenler göçebelik geleneğinden geliyordu.Giderek \n yerleşik yaşama alışarak tarımla uğraşmaya başladılar Sevr \n anlaşmasından sonra Yunanlar önce İzmir’i sonra (26 Mayıs 1919) Manisa’yı işgal ettiler Saruhanlı’ların büyük direnci yüzünden ancak on dört ay \n sonra 1920 Haziranında girebildiler. 7 Eylül 1922’de işgalden kurtulan bölgeye, Balkan ülkelerinden ve \n doğudan gelen Türk göçmenleri yerleştirilmeye başlandı. Saruhanlı topraklarının verimli \n olması ve boş olması nedeniyle bölgeye sürekli bir göç yaşandı. Bu göç 1960 \n yıllarına kadar devam etti. ",
                "Türkiye'nin Ege Bölgesi'nde bulunan Manisa ilinin ilçelerinden biridir. 1954 yılında, 6324 numaralı \n karar ile kurulmuştur. Manisa'ya 155 km, Uşak'a ise 70 km mesafede yer alır. \n İlçe sınırlarından Gediz Nehri'nin önemli kollarında biri olan \n Selendi çayı geçer. Asıl geçim kaynağı tütüncülük, hayvancılık ve tarımdır. Ayrıca Pınarlar, Eskin, Terziler, Kürkçü ve Hacıhaliller köylerinde \n son yıllarda kirazcılık artmıştır. Kınık mahallesi piknik alanı, Gavur evleri kaya mezarları, Bayraklı \n anıtı Selendi'nin gezilebilecek yerleridir. Merkez nüfusu 8.108'dir. Köyleri de dahil \n toplam nüfusu 26.500'dür fakat son 50 yıldır sürekli göç veren ilçenin göç eden \n kişileri de hesaba katıldığında nüfusu 77.000'i geçmektedir. Manisa'nın en az yoğunluklu ilçesidir.",
                "İlçenin adının sumak bitkisinden geldiği de söylenir ve gittikçe Somaklı'dan Soma ismine dönüştüğü \n rivayetleri de vardır. Soma, Yunt Dağı silsilesinin eteklerine kurulmuştur. \n Savaştepe fay hattı da denilen ve Balıkesir'in Pamukçu beldesinden \n başlayıp Bergama'ya kadar uzanan Türkiye'nin en aktif fay hatlarından birinin üstündedir. ",
                "Türkiye'nin Ege Bölgesi'nde bulunan Manisa ilinin ilçelerinden biridir. 12 Kasım 2012'de TBMM'de \n kabul edilen 6360 sayılı kanun ile Manisa merkez ilçesinin ikiye bölünmesi \n sonucu ilçe olmuştur.",
                "Sultan II. Murat döneminde Dalbahçe Köyü çevresine yerleşen Turgud Aşireti tarafından kurulmuş ve \n zamanla ovaya inerek bugünkü yerini almıştır. Yunanların, İzmir'i işgalinden \n 10 gün sonra da Turgutlu'yu işgal edilmiştir. Bu tarihten, 7 Eylül \n 1922 yılına kadar ilçe işgal altında kalmıştır. Kurtuluş savaşı sonrası Yunan askeri ilçeden çekilirken Bozkurt ve Küllük mahalleleri hariç tüm \n mahallelerini yakmıştır. ",
                "Türkiye'nin Ege Bölgesi'nde bulunan Manisa ilinin İlçelerinden biridir. 12 Kasım 2012'de Manisa il \n merkezinin ikiye bölünmesiyle ayrı bir ilçe olmuştur. 257.993 kişilik nüfusuyla \n Manisa'nın en yüksek nüfuslu ilçesidir.[1] İlçenin adı, 13. yüzyılda \n yaşamış tasavvuf ve Türk halk şairi Yunus Emre'den gelmektedir. İlçe, Gediz Ovasının üzerinde ve Spil Dağı ile Yamanlar Dağı'nın eteğinde \n kuruludur. İlçenin güneyinde Spil ve Yamanlar Dağı, batısında Menemen ilçesi, kuzeyinde Yunt Dağları, \n doğusunda Şehzadeler ilçesi ve kuzey doğusunda Saruhanlı ilçesi bulunur. Gediz Nehri \n ilçenin içinden, yerleşim yerlerinin ise kuzeyinden geçer. İlçenin ana ekonomik \n geçim kaynağı tarım ve sanayi'dir. ",
            }; //sabitilceler dizisinin index'ine orantılı olarak bilgi metni hazırladım.

            string[] avantaj = {
                "İlçede Celal Bayar Üniversitesi'nin bölümleri de bulunmaktadır. İzmir-Ankara asfaltı üzerinde olup \n ulaşımı kolay bir ilçedir. ",
                "Bölgeye, il merkezinden taksi veya Manisa Otogarı’ndan hareket eden Akhisar dolmuşlarıyla da ortalama \n 45 dakika içerisinde ulaşım sağlanabilmektedir.",
                "Alaşehir'de Filadelfiya Aziz Yuhanna Kilisesi (turizm için Philadephia St. Jean Church diye de tanıtılır), \n Bizans dönemine ait sur kalıntıları, Yıldırım Bayezid Camii, Şeyh Sinan Camisi ve \n Türbesi, Güdük Minare Camisi, Yağhane Camisi, Kadı Şeyh Camisi ve Türbesi, \n Rahmanlı Dede (Tepeköy mahallesinde) bulunmaktadır. ",
                "İlçedeki en önemli gelir kaynağı halıcılıktır. Halıcılığın yanı sıra hayvancılık, yayla bağcılığı ile elma, \n kiraz, ayva, antep fıstığı ve erik üretimi de yapılmaktadır. Demirci güveci ve kebabı meşhurdur. \n Plato yüzeyinde kurulmuş olan ilçe merkezi engebe ve yükseltiye bağlı olarak ulaşım en büyük problem olmuştur. \n Buna bağlı olarak Manisa'nın diğer ilçe merkezlerine göre hızlı bir gelişme gösterememiştir. \n İlçe halkının eskiden beri eğitime verdiği önem ilçede bir fakültenin kurulmasına zemin hazırlamış ve \n Celal Bayar Üniversitesi Demirci Eğitim Fakültesi kurulmuştur. Eğitim Fakültesinin kuruluşuyla \n beraber nüfus, ekonomik ve sosyokültürel yapı da buna bağlı olarak değişmiştir. Celal Bayar Üniversitesi Eğitim Fakültesi'nin \n kurulmasıyla birlikte şehir nüfusu 20.000'in üzerine çıkmıştır. Bunda hem köylerden göç, hem de öğrenci sayısı etkili olmuştur.",
                "İlçenin en önemli ekonomik faaliyeti tarımdır. Yaz ayların özellikle kavun, karpuz, sanayi tipi domates, \n sofralık domates, sanayi tipi kırmızı biber, yeşil biber, üzüm ve zeytin üretimi  yoğun olarak yapılırken, \n son dönemlerde mısır ekimi de artmıştır. Bölgenin eski tarımsal faaliyeti olan tütün üretimi de devam etmektedir. \n Kış aylarında ise lahana, brokoli, karnabahar gibi ürünlerin tarımı yapılmaktadır. ",
                "deniz seviyesinden 680 Metre yüksekliktedir. İlçe toprakları küçük akarsu vadileriyle yarılmış bir yayla \n görünümündedir. İlçenin yazları kurak ve sıcak, kışları ılık ve yağışlı bir iklimi \n vardır. Yıllık yağış ortalaması 500 – 700 m³ arasında değişmektedir. Ortalama sıcaklık \n 11 - 13 c° dir. Ormanlık alanları ilçemizin toplam alanında %45 gibi önemli bir yer tutmaktadır. En önemli \n akarsuyu Gördes (Kum çayı) deresidir.  ",
                "İlçe Akdeniz ikliminin etkisi altındadır.Genel olarak ılımandır.Yazları sıcak ve kurak,kışları ılık ve \n yağışlı geçer.Ova kısımlarında havalar kışın ılık,yazın sıcak geçer.Dağlık kesimde \n kışlar biraz sert,karlı ve soğuk, yazlar daha serin gözlenmektedir. İlçenin en önemli \n geçim kaynağı tarımdır. Özellikle kavun, ilçenin en önemli tarım ürünüdür. Son yıllarda Kırkağaç Kavunu, Karakurt \n Ovasında daha kaliteli bir şekilde yetişmektedir. Kırkağaç'taki gezilip görülecek yapı ve alanlar şunlardır;\r\n\r\n    Nakrasa\r\n    Stratonikeia\r\n    Khliara\r\n    Yortan\r\n    Kaya mezarları\r\n    Tarihi Çiftehanlar Camii\r\n    Kırık Minaresi\r\n    Sarı Hoca Camii\r\n    Eski Rum/Ermeni evleri",
                "Genel olarak susuz tarım yapılır. Yetiştirilen ürünler arasında çilek, buğday, arpa, zeytin,haşhaş, üzüm \n ve tütün yetiştiriciliğide yer almaktadır. Özellikle son 5 yılda ilçenin kaderi \n çilek sayesinde değişti. Ekonomi yüzde 80 canlandı, göç önlendi. Hatta göç edenlerin bir \n kısmı da döndü. 10 yıl önce 2 serada başlayan üretim, 2 bin dekar araziye yayıldı. Üretimin gelecek yıllarda daha \n da yaygınlaşacağı ümit ediliyor. Ayrıca son yıllarda tavukçuluk da yaygın olarak yapılmaktadır. \n İlçenin baraj gölü kıyısında bulunması sebebiyle tatlı su balıkçılığı da ilçe \n ekonomisine büyük katkı yapmaktadır. İlçede kurulan su ürünleri kooperatifi, baraj gölünden \n elde edilen bu balıkların üretim fazlasını ilçe dışına pazarlayarak ilçe ekonomisine katkı yapmaktadır. \n İlçede Celal Bayar Üniversitesi'ne bağlı 1 Meslek Yüksekokulu bulunmaktadır.",
                "Meşhur yemekleri Su böreği, peynir böreği, susam böreği, höşmerim, kuzu ve oğlak dolması, sura, güveç, \n buğulama, şekerli pide, kakırdaklı pidedir. Kula'nın Gediz vadisi kenarından çıkan, \n ülke çapında ünlü bir de maden suyu var. Günümüzde 'Kuladokya' olarak anılan peribacaları \n ise, Burgaz köyü civarında. İlçede Divlit Yanardağı, Kuladukya, Emir Kaplıcaları, Kibele-Attis Kabartmaları ve \n Meryem Ana Kilisesi bulunmaktadır.",
                "Dünya tarihinde paranın ilk basıldığı yer burası olarak bilinmektedir. Tarihi ve turistlik mekanları ile \n ilgi toplayan Salihli'nin tarihi yerlerin başında ise; Sart Antik Kenti, Artemis \n Tapınağı, Sardes Antik Tiyatrosu, Sardes Kilisesi, Tarihi Şehir Hamamı, Hamidiye Camii, \n Bintepe Tümülüsleri gelmektedir.",
                "Belediye tarafından her yıl 4 Eylül Bağ Bozumu Şenlikleri yapılmaktadır. Sarıgöl'de 2004 yılında Sarıgöl \n 1. Sultaniye Üzüm Festivali başlatıldı. İlçede 1993 yılında kurulan, Sarıgöl FM \n adını taşıyan radyo istasyonu 1996 yılında faaliyetine son verdi. 1998 yılında kurulan \n Sarıgöl Gazetesi yayın hayatına hâlen devam etmekte ve 2008'de kurulan Sarıgöl 4 Eylül Gazetesi ise kapanmıştır. Son \n olarak ise ilçede haftalık Sarıgöl Gündem Gazetesi yayın hayatına başladı. Sarıgöl'de eski bir \n gelenek olan Olcak Dede her yıl Mayıs ayının ilk Cumartesi günü yapılmaktadır. \n Sarıgöl İlçesi'nin Ayan Mahallesi halkı tarafından her yıl Muharrem ayında, aşure ve \n keşkek günü düzenlenmekte. Bu gelenek 200 yıldan bu yana devam etmekte olup, son 20 yılda bu geleneğe \n yemekler de ilave edilerek, tüm ilçe halkı tarafından yenmektedir. ",
                "Manisa iline yakın olmasından dolayı Saruhanlı ilçesinin ulaşımı gelişmiştir. Saruhanlı ilçesine rahatlıkla \n ulaşabilirsiniz. Gediz Ovası üzerinde yer alan Saruhanlı ilçesi verimli topraklara \n sahiptir. Bundan dolayı Saruhanlı ilçesi tarım açısından çok gelişmiştir. Celal \n Bayar Üniversitesinin Meslek Yüksek Okulu bulunan Saruhanlı ilçesi nufüsü yoğundur.\r\n\r\nZeytin ağaçları ve üzüm \n bağları ile kaplı olan Saruhanlı ilçesi yeşil tabiatı ve temiz havası ile dikkat çekmektedir. \n Saruhanlı ilçesinde turistlik öneme sahip tarihi yapı yer almamaktadır. Saruhanlı \n ilçesinde yer alan Kum Çayı çevresinde kurulan mesire alanları ilçenin en çok \n dikkat çeken yerleridir.",
                "Gediz Nehrinin en büyük kolu olan selendi çayı kış aylarında Gediz Nehrinden daha fazla su taşır. İlçenin \n tarihinde aldığı en büyük yatırımlar; tekel yaprak tütün depolama işletmeleri ve \n yatılı ilköğretim bölge okuludur. Selendi'nin tarhana, höşmerim, keşkek ve yufkası \n meşhurdur. İlçede üretilen Amerikan tipi küçük yapraklı tütünler çok değerlidir. ",
                "İlçede linyit kömürü madenleri bulunur. Ayrıca iki adet termik santral vardır ve ikinci termik santralde \n faaliyetlerine başlamıştır. Türkiye'nin elektrik ihtiyacının %10'unu karşılamaktadır. \n 2015 yılının Kasım ayında dönemin Enerji ve Tabii Kaynaklar Bakanı Ali Rıza \n Alaboyun Soma’da 100 ton altın rezervi bulunduğunu açıkladı.",
                "Manisa kalesi, Spil Dağı Milli Parkı, Ulu Cami Ve Külliye, Manisa Müzesi, Kybele Kaya anıtı, Niobe Ağlayan Kaya \n ve Manisa Yeni Hanıyla meşhurdur.",
                "İlçenin en önemli turistik tesisi Urganlı Kaplıcaları'dır. Urganlı Kaplıcaları, suları karbondioksitli ve \n bikarbonatlıdır. Sıcaklığı 50 ile 78 santigrat derece arasında değişmektedir. \n Karaca Ali Kanyonu, Küp yar ve Ovacık Yaylası ilçenin diğer turistlik bölgeleridir.\n İlçe yakınındaki Bozdağlar da, doğa yürüyüşleri için tercih edilen yerlerdendir. İlçede Celal Bayar Üniversitesi Hasan \n Ferdi Turgutlu Teknoloji Fakültesi ve Celal Bayar Üniversitesi Turgutlu Meslek Yüksek Okulu bulunmaktadır.",
                "Aigai antik kenti, Yoğurtçu Kalesi ve Ağlayan Kaya'sıyla meşhurdur. İlçede Celal Bayar Üniversitesi'nin Şehit \n Prof. Dr. İlhan Varank Yerleşkesi ve Uncubozköy mahallesinde Sağlık Yerleşkesi \n ile Tıp Fakültesi bulunur. ",
            }; //sabitilceler dizisinin index'ine orantılı olarak ilçelerin avantajları hakkında bilgiler hazırladım.


            //Kullanıcı için karşılama ekranı.
            Console.WriteLine("!-------Manisa İlçeleri-------!");
            Console.WriteLine("Manisa ilçeleri hakkında bilgi alma ve sıralama servisine hoş geldiniz. Komutları öğrenmek için 'yardim' yazınız.\n");
            Console.Write("--> ");
            string komut = Console.ReadLine(); //Manisa İlçeleri hizmetim için kullanıcının neleri kullanmak istediğini kullanıcıdan girdi alıyorum.
            komut = komut.ToLower(); //Girilen komutun büyük harf ya da istenmeyen biçimde bir büyük bir küçük girilse dahi arkaplanda küçük harfe dönüştürülerek kullanıcı için rahatlık sağlıyor.

            if (komut == "detay") //Detay komutu girildiği zaman detay ekranına gidecek.
            {
            detay: //Yanlış komut girildiğinde ya da kullanıcının bir önceki ekrana gitmesi için etiket belirttim.

                Console.Clear(); //Karşılama ekranındaki yazıların gözükerek görüntü kirliliği yapmaması için konsol ekranını temizledim.

                //Detay karşılama ekranı
                Console.WriteLine("!-------İlçe Bilgi Hizmeti-------!");
                Console.WriteLine("Bütün ilçeler hakkında detayları görüntülemek için 'hepsi', merak ettiğiniz ilçeyi görüntülemek için 'sec' yazabilirsiniz.");

                Console.Write("--> ");
                komut = Console.ReadLine();
                komut = komut.ToLower(); //Komut girdisi alıp, küçük harfe dönüştürerek kullanıcıya rahatlık sağladım.

                if (komut == "hepsi")
                {
                    Console.Clear(); //Önceki ekranın konsol ekranını temizledim.

                    Console.WriteLine("!-------Bütün İlçeler-------!\n");
                    for (int i = 0; i < sabitilceler.Length; i++)
                    {
                        if (i != sabitilceler.Length - 1) //Son yazılandan sonra kesme işareti olmaması için burada eğer i, sabitilceler'in son dizisinde değilse kesmek işaretli yazsın. Son dizisiyse else çalışıp kesme işaretsiz yazsın.
                        {
                            Console.WriteLine($"İlçe: {sabitilceler[i]}\nBILGI: {bilgi[i]}\n\nAVANTAJ: {avantaj[i]}\n--------\n");
                        }
                        else
                        {
                            Console.WriteLine($"İlçe: {sabitilceler[i]}\nBILGI: {bilgi[i]}\n\nAVANTAJ: {avantaj[i]}");
                        }
                    } //

                    Console.ReadKey();
                    Console.Clear();
                    goto detay; //Kullanıcı tuşa bastıktan sonra artık yeni bir girdi istenmediği için önceki ekrana gidiyor.
                }
                else if (komut == "sec")
                {
                sec:
                    Console.Clear(); //Kullanıcı yeni ekrana geçtiği için ekranı temizledim.

                    Console.WriteLine("!-------İlçe Seçiniz-------!");
                    Console.Write("İlçeler: ");
                    for (int i = 0; i < sabitilceler.Length; i++)
                    {
                        Console.Write(sabitilceler[i].ToString() + " ");
                    }
                    Console.WriteLine("\n");
                    Console.Write("--> "); //Ekrana kullanıcının seçebileceği ilçeleri listeledim ve aşağıda komut olarak ilçe ismi girilirse ilgili ilçenin bilgisini gösterecek.
                    komut = Console.ReadLine();
                    komut = komut.ToLower();

                    //Tek tek olası girilebilecek ilçe isimleri için kontrol yapıları oluşturdum ve girildiğinde birbiriyle orantılı index konumları ile ekrana yazdırdım.
                    if (komut == "ahmetli")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[0]}\nBILGI: {bilgi[0]}\n\nAVANTAJ: {avantaj[0]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "akhisar")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[1]}\nBILGI: {bilgi[1]}\n\nAVANTAJ: {avantaj[1]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "alaşehir")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[2]}\nBILGI: {bilgi[2]}\n\nAVANTAJ: {avantaj[2]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "demirci")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[3]}\nBILGI: {bilgi[3]}\n\nAVANTAJ: {avantaj[3]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "gölmarmara")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[4]}\nBILGI: {bilgi[4]}\n\nAVANTAJ: {avantaj[4]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "gördes")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[5]}\nBILGI: {bilgi[5]}\n\nAVANTAJ: {avantaj[5]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "kırkağaç")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[6]}\nBILGI: {bilgi[6]}\n\nAVANTAJ: {avantaj[6]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "köprübaşı")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[7]}\nBILGI: {bilgi[7]}\n\nAVANTAJ: {avantaj[7]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "kula")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[8]}\nBILGI: {bilgi[8]}\n\nAVANTAJ: {avantaj[8]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "salihli")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[9]}\nBILGI: {bilgi[9]}\n\nAVANTAJ: {avantaj[9]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "sarıgöl")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[10]}\nBILGI: {bilgi[10]}\n\nAVANTAJ: {avantaj[10]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "saruhanlı")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[11]}\nBILGI: {bilgi[11]}\n\nAVANTAJ: {avantaj[11]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "selendi")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[12]}\nBILGI: {bilgi[12]}\n\nAVANTAJ: {avantaj[12]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "soma")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[13]}\nBILGI: {bilgi[13]}\n\nAVANTAJ: {avantaj[13]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "şehzadeler")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[14]}\nBILGI: {bilgi[14]}\n\nAVANTAJ: {avantaj[14]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "turgutlu")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[15]}\nBILGI: {bilgi[15]}\n\nAVANTAJ: {avantaj[15]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "yunusemre")
                    {
                        Console.WriteLine($"İLÇE: {sabitilceler[16]}\nBILGI: {bilgi[16]}\n\nAVANTAJ: {avantaj[16]}");
                        Console.ReadKey();
                        Console.Clear();
                        goto sec;
                    }
                    else if (komut == "geri") //Kullanıcı ilçe seçmek yerine başka bir işlem yapmayı isterse bir önceki ekran olan detay ekranına gider.
                    {
                        Console.Clear();
                        goto detay;
                    }
                    else
                    {
                        Console.Clear();
                        goto sec; //Geçersiz girdi olursa kullanıcıdan uygun girdiyi giresiye kadar sec ekranında tutar.
                    }
                }
                else if (komut == "geri") //Kullanıcı detay ekranından bir önceki ekran olan başlangıç ekranına gider.
                {
                    Console.Clear();
                    goto baslangic;
                }
                else
                {
                    goto detay; //Geçersiz komut girişi olursa programın sonra ermemesi için uygun girdi girilesiye kadar ekranda tutar.
                }

            }
            else if (komut == "sirala")
            {
            sirala: //Yanlış komut girildiğinde ya da kullanıcının bir önceki ekrana gitmesi için etiket belirttim.
                Console.Clear(); //Yeni ekran olduğu için konsol ekranını temizledim.

                Console.WriteLine("!-------İlçe Sıralama Hizmeti-------!");
                Console.WriteLine(" Nüfusa göre sıralamak için; artannufus, azalannufus\n Alfabetik olarak sıralamak için: alfabetik\n İlçe isminde aramak için 'metiniceren'\n");

                Console.Write("--> ");
                komut = Console.ReadLine();
                komut = komut.ToLower(); //Kullanıcıya rahatlık sağlamak için büyük-küçük harf duyarlılığını küçük harfe dönüştürerek çözdüm.
                Console.WriteLine();

                if (komut == "artannufus")
                {
                    Array.Sort(ilcekoleksiyon, delegate (Ilce ilce1, Ilce ilce2)
                    {
                        return ilce1.Nufus_sayi.CompareTo(ilce2.Nufus_sayi);
                    }); //Dizi sıralama metodu olan Array.Sort'u kullandım.
                        //İlçe sınıfının metodunun parametrelerine uygun olarak girdiğim ilce_ad ve nufus_sayi tanımlamalarını barındırdığım ilcekoleksiyon dizisindeki girdileri
                        //delegate kullanarak verileri karşılaştırmak için referans tipinde ilce1 ve ilce2'leri tanımladım. İlçenin nüfus_sayi'larına göre sıralamak istediğimden CompareTo kullandım.
                        //İlçe koleksiyonu içindeki verileri Array.Sort'un kullandığı QuickSort yöntemiyle başlangıçtaki öğeleri düzenleyip sonra bir sonraki öğelere geçip karşılaştırma ve sıralama yaptırdım.

                    //Radix ya da Bubble Sort gibi sıralama algoritmaları dizi erişimi ve karşılaştırma miktarları olarak daha verimli olsa da projem kapsamlı olmadığı için mevcuttaki algoritmayı kullandım.

                    Array.Reverse(ilcekoleksiyon); //Sıralama yapınca azalan nüfusdan başladığı için diziyi ters çevirdim ve artan nüfus şekline çevirdim.
                    Console.WriteLine("İlçe | Nüfus");
                    Console.WriteLine("-----|------");
                    foreach (Ilce ilce in ilcekoleksiyon)
                    {
                        Console.WriteLine($"{ilce.Ilce_ad} - {ilce.Nufus_sayi}");

                    } //ilcekoleksiyonu dizimdeki verileri. İlçe sınıfımı tanımlayarak ilce_ad ve nufus_sayi verilerini get yaparak ekranda gösterdim.

                    Console.ReadKey();
                    goto sirala; //Sıralama komut ekranına döner.
                }
                if (komut == "azalannufus")
                {
                    Array.Sort(ilcekoleksiyon, delegate (Ilce ilce1, Ilce ilce2)
                    {
                        return ilce1.Nufus_sayi.CompareTo(ilce2.Nufus_sayi);
                    }); //ilcekoleksiyon dizimdeki nüfus verilerini karşılaştırıp diziyi sıralattım.

                    Console.WriteLine("İlçe | Nüfus");
                    Console.WriteLine("-----|------");
                    foreach (Ilce ilce in ilcekoleksiyon)
                    {
                        Console.WriteLine($"{ilce.Ilce_ad} - {ilce.Nufus_sayi}");
                    } //ilcekoleksiyon dizimdeki verileri sınıf üzerinden ulaşarak ekrana yazdırdım.

                    Console.ReadKey();
                    goto sirala;

                }
                else if (komut == "alfabetik")
                {
                    Array.Sort(sabitilceler); //Dizimdeki metinleri Array.Sort ile A-Z'ye şekilde sıraladım.
                    Console.WriteLine("A-Z'ye İlçeler");
                    Console.WriteLine("--------------");
                    for (int i = 0; i < sabitilceler.Length; i++)
                    {
                        Console.Write(sabitilceler[i].ToString() + "\n");
                    } //Sıraladığım sabitilceler dizisinin elemanlarını döngüyle ekrana yazdırdım.

                    Console.ReadKey();
                    goto sirala;

                }
                else if (komut == "metiniceren")
                {
                    Console.Write("Aranacak Terim: ");
                    komut = Console.ReadLine();
                    if (string.IsNullOrEmpty(komut) != true) //Kullanıcının aradığı harf ya da kelime komutu boş ya da değersiz ise sorgulama yapmayacak.
                    {
                        int bulundu = 0; //İlgili girdiye uygun ilçe sayısını kullanıcıya bildirmek için bulundu adında sayaç ekledim.
                        Console.WriteLine("\nBulunan İlçeler");
                        Console.WriteLine("--------------");
                        for (int i = 0; i < sabitilceler.Length; i++) //İlçelerin uyup uymadığını tek tek kontrol eder.
                        {
                            if (sabitilceler[i].Contains(komut)) //Kullanıcının aramak istediği harf ve kelime içeren ilçeleri filtreler. String bir char dizisi olduğu için ilçelerin harflerine de bakar.
                            {
                                bulundu++; //Bulduğunda sayı artacak.
                                Console.Write(sabitilceler[i].ToString() + "\n"); //Kullanıcının içermesini istediği girdiye uygun ilçeyi ekrana yazdırır.
                            }
                        }


                        if (bulundu == 0)
                        {
                            Console.WriteLine($"\nBöyle bir ilçe mevcut değil."); //Girdiye uygun bir şey bulunmadıysa bunu yazar.
                        }
                        else
                        {
                            Console.WriteLine($"\n{bulundu} tane ilçe bulundu."); //Girdiye uygun olan ilçelerin sayısını yazar.
                        }
                    }
                    Console.ReadKey();
                    goto sirala; //Kullanıcı ekrandakileri görüntüledikten sonra tuşa basarak önceki ekran olan sıralama ekranına döner.
                }
                else if (komut == "geri")
                {
                    Console.Clear();
                    goto baslangic; //Sıralama ekranından çıkıp başlangıç ekranına döner.
                }
                else
                {
                    goto sirala; //Uygun girdi yapılasıya kadar sıralama komut ekranında bekler.
                }

            }
            else if (komut == "yardim")
            {
                //Yardım ekranını yazdırdım ve kullanıcıdan herhangi bir girdi beklemedim. Kullanıcı tuşa basınca önceki ekran olan başlangıç ekranına dönecek.
                Console.Clear();
                Console.WriteLine("!-------Yardım ekranına hoş geldiniz.-------!\n");
                Console.WriteLine("1- İlçeler hakkında bilgi edinmek için 'detay' yazınız.\n hepsi : Bütün ilçelerin bilgilerini ekrana yazdırır.\n sec : Girilen ilçenin bilgisini ekrana yazdırır.\n");
                Console.WriteLine("2- İlçeler hakkında sıralama işlemi yapmak için 'sirala' yaziniz.\n artannufus : En yüksekten, en az nüfusu olana doğru sıralar.\n azalannufus : En düşükten, en fazla nüfusu olana doğru sıralar.\n alfabetik : İlçeleri alfabetik olarak sıralar.\n metiniceren : Kullanıcı tarafından girilen metni ilçe isminde arar.\n");
                Console.WriteLine("3- Komutları öğrenmek için 'yardim' yazınız.");
                Console.WriteLine("4- Hakkında ekranına gitmek için 'hakkinda' yazınız.");
                Console.WriteLine("5- Önceki ekrana dönmek için 'geri' yazınız.");
                Console.WriteLine("6- Programdan çıkmak için 'cik' yazınız.");
                Console.ReadKey();
                Console.Clear();
                goto baslangic;
            }
            else if (komut == "hakkinda")
            {
                //Hakkında ekranını yazdırdım ve tuşa basıldığında önceki ekrana dönecek.
                Console.Clear();
                Console.WriteLine("!-------Hakkında-------!\n");
                Console.WriteLine("Berkay Gediz - Manisa İlçelerinin Bilgilerini Gösterme ve Sıralama");
                Console.ReadKey();
                Console.Clear();
                goto baslangic;
            }
            else if (komut == "cik")
            {
                Environment.Exit(0); //cik komutu girildiğinde programdan çıkılacak. Exit için hata kodu olarak 0 belirttim çünkü daha kullanıcının kullanımını kayıt altına almadım.
                                     //Kayıt altına alsaydım projeye özel hata kodu belirtebilir ve kullanıcıların bu hata kodunu alması durumunda çözüm sunabilirdim.
            }
            else
            {
                Console.Clear();
                goto baslangic; //Kullanıcı uygun komutu giresiye kadar başlangıç ekranında bekler.
            }
        }
    }
}