using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace OlasilikHesaplama
{
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        // Public Variables;
        ArrayList _sorularArray, _cevaplarArray;
        Random _random;
        private bool _showAnswer = false, _showExportError = true;
        private int _slipRate = 20;

        // Responsive Variables;
        private int _standardLabelFont = 12;
        private int _refreshButtonX = 12, _refreshButtonY = 204;
        private int _printQuestionButtonX = 239, _printQuestionButtonY = 204;
        private int _showAnswerButtonX = 120, _showAnswerButtonY = 204;
        private int _textBuyutButtonX = 564, _textBuyutButtonY = 208;
        private int _textKucultButtonX = 635, _textKucultButtonY = 208;
        private int _textSifirlaButtonX = 706, _textSifirlaButtonY = 208;
        private int _rdAllButtonX = 362, _rdAllButtonY = 204;
        private int _rdOnlyButtonX = 362, _rdOnlyButtonY = 239;
        private int _thisX = 807, _thisY = 307;
        private int _labelCevapX = 91, labelCevapY = 118;
        private int _label2X = 13, _label2Y = 118;

        // Arrays;
        private readonly string[] _sorular = {
            "1- Bir zar atışında, 2 farklı zarın toplamının 7 gelme olasılığı nedir?",
            "2- Bir desteden bir kart çekildiğinde, kırmızı bir kartın çekilme olasılığı nedir?",
            "3- Bir madeni paranın iki kez atılması durumunda, her iki atışta da tura gelme olasılığı nedir?",
            "4- İçinde 10 top bulunan bir torbadan 4 top çekildiğinde en az birinin kırmızı olma olasılığı nedir? (3 kırmızı renkte, 7 diğer renkte.)",
            "5- Bir zarın atılması durumunda, çift sayı gelme olasılığı nedir?",
            "6- Bir torbadan 2 beyaz, 3 mavi ve 4 sarı top olduğunu varsayalım. Bir topun mavi olma olasılığı nedir?",
            "7- Bir zarın atılması durumunda, 4 veya 5 gelme olasılığı nedir?",
            "8- Bir torbada 5 kırmızı ve 3 mavi top bulunmaktadır. Torbadan rastgele seçilen bir topun kırmızı olma olasılığı nedir?",
            "9- Bir torbada 2 kırmızı, 3 mavi ve 5 sarı top var. Rastgele çekilen bir topun kırmızı olma olasılığı nedir?",
            "10- İki madeni paranın atılması durumunda, en az birinin tura gelme olasılığı nedir?",
            "11- Bir zarın atılması durumunda, 3 gelme veya bir çift sayı gelme olasılığı nedir?",
            "12- Bir torbadan çekilen iki topun da kırmızı olma olasılığı, 4 kırmızı, 2 mavi ve 3 yeşil top içeren torbada nedir?",
            "13- Bir desteden bir kart çekildiğinde, bir as çekme olasılığı nedir?",
            "14- Bir torbadan çekilen üç topun da aynı renk olma olasılığı nedir? (Torbada 3 mavi, 4 kırmızı ve 2 yeşil top vardır.)",
            "15- Bir zarın atılması durumunda, tek sayı gelme olasılığı nedir?",
            "16- Bir desteden iki kart çekildiğinde, her iki kartın da kupa olma olasılığı nedir?",
            "17- Bir torbadan 2 siyah, 4 beyaz ve 3 gri top olduğunu varsayalım. Bir topun beyaz olma olasılığı nedir?",
            "18- Bir zarın atılması durumunda, 6 gelme veya çift sayı gelme olasılığı nedir?",
            "19- Bir desteden üç kart çekildiğinde, hiç vale çekmeme olasılığı nedir?",
            "20- Bir torbadan çekilen bir topun mavi olma olasılığı, 3 kırmızı, 4 mavi ve 2 sarı top içeren torbada nedir?",
            "21- İki zarın atılması durumunda, toplamın 9 gelme olasılığı nedir?",
            "22- Bir desteden bir kart çekildiğinde, bir kupa veya bir vale çekme olasılığı nedir?",
            "23- Bir torbadan çekilen iki topun da farklı renklerde olma olasılığı nedir?",
            "24- Bir zarın atılması durumunda, 2 gelme ve bir çift sayı gelme olasılığı nedir?",
            "25- Bir desteden iki kart çekildiğinde, en az birinin kupa ve diğerinin karo olma olasılığı nedir?",
            "26- Bir A olayının olma olasılığı nedir?",
            "27- Bir zarın tek atışında 6 gelme olasılığı nedir?",
            "28- İki zar atıldığında, toplamlarının 7 olma olasılığı nedir?",
            "29- Bir kutuda 5 kırmızı ve 5 mavi kalem var. İki kalem çekildiğinde her ikisinin de kırmızı olma olasılığı nedir?",
            "30- Bir zar üç kez atılıyor. Üç atışta da çift sayı gelme olasılığı nedir?",
            "31- Bir madeni para 4 kez atılıyor. Tura ve yazıların eşit sayıda çıkma olasılığı nedir?",
            "32- Bir torbada 4 kırmızı, 3 mavi ve 3 yeşil top var. Uç top çekildiğinde tüm topların aynı renk olma olasılığı nedir?",
            "33- Bir çift zar atılıyor. Toplamlarının 12 olma olasılığı nedir?",
            "34- Bir torbada 5 altın, 3 gümüş ve 2 bronz madalya var. İki madalya çekildiğinde, her ikisinin de altın olma olasılığı nedir?",
            "35- Üç kart çekildiğinde, hepsinin farklı takımdan (kupa, karo, sinek, maça) olma olasılığı nedir?",
            "36- Bir torbada 15 top var: 5 kırmızı, 5 mavi ve 5 yeşil. Üç top çekildiğinde, en az birinin kırmızı olma olasılığı nedir?",
            "37- İçinde 200 soru bulunan bir programda bir sorunun denk gelme olasılığı nedir?",
            "38- Bir madeni para 3 kez atılıyor. Her üç atışın da aynı yüz (tura veya yazı) gelme olasılığı nedir?",
            "39- Bir futbol takımının üç maç yapması ve hepsini kazanma olasılığı, maç başına kazanma şansı %70 olduğunda nedir?",
            "40- Bir zar iki kez atılıyor. Her iki atışta da 6 gelme olasılığı nedir?",
            "41- Bir torbada 6 kırmızı ve 4 mavi top bulunuyor. İki top çekildiğinde her ikisinin de kırmızı olma olasılığı nedir?",
            "42- Bir kutuda 3 kırmızı, 2 mavi ve 1 sarı kalem bulunuyor. Rastgele bir kalem çekme olasılığı nedir?",
            "43- Bir zar üç kez atılıyor. İlk iki atışta çift, üçüncü atışta tek sayı gelme olasılığı nedir?",
            "44- Bir futbol maçında, penaltıdan gol atma şansı %80 ise, üç penaltıdan en az iki gol atma olasılığı nedir?",
            "45- Bir zarın tek atışında 2 veya 5 gelme olasılığı nedir?",
            "46- Bir kutuda 5 kırmızı, 3 mavi ve 2 yeşil top var. İki top çekildiğinde en az birinin yeşil olma olasılığı nedir?",
            "47- Bir zarın 4 kez atılması durumunda, hiç 3 gelmeme olasılığı nedir?",
            "48- Bir torbada 7 beyaz, 5 siyah ve 3 kırmızı top bulunuyor. İlk iki topun beyaz olma olasılığı nedir?",
            "49- Bir zarın tek atışında 1 gelme olasılığı nedir?",
            "50- Bir kutuda 4 kırmızı ve 6 mavi kalem var. Rastgele bir kalem çekme olasılığı nedir?",
            "51- Bir torbada 2 altın, 3 gümüş ve 5 bronz madalya var. İki madalya çekildiğinde, her ikisinin de bronz olma olasılığı nedir?",
            "52- İçinde 200 soru bulunan ve soruları rastgele ekrana yazdıran bir bilgisayar programında çıkan ilk sorunun 16. soru olma ihtimali nedir?",
            "53- Bir zarın 4 kez atılmasında her seferinde 2 gelme olasılığı nedir?",
            "54- Bir torbada 10 kırmızı, 5 mavi top varken rastgele çekilen bir topun mavi olma olasılığı nedir?",
            "55- Bir torbada 5 kırmızı, 5 mavi, 10 yeşil top var. Üç top çekildiğinde hepsinin yeşil olma olasılığı nedir?",
            "56- İki zar atılıyor, ilk zarın 5 ve ikinci zarın 6 gelme olasılığı nedir?",
            "57- Bir desteden çekilen ilk iki kartın as olma olasılığı nedir?",
            "58- Bir zarın iki kez atılmasında her seferinde 1 gelme olasılığı nedir?",
            "59- Bir madeni para üç kez atıldığında üçünün de tura gelme olasılığı nedir?",
            "60- Bir desteden çekilen bir kartın sinek olma olasılığı nedir?",
            "61- Bir torbada 3 kırmızı, 2 mavi ve 5 yeşil top varken iki topun da mavi olma olasılığı nedir?",
            "62- Üç zar atılıyor, hepsinin toplamının 18 olma olasılığı nedir?",
            "63- Bir kutuda 10 kırmızı ve 10 mavi kalem var. Bir kalem çekme olasılığı nedir?",
            "64- Bir futbol takımının bir maçı kaybetme olasılığı %30 ise, üç maç üst üste kaybetme olasılığı nedir?",
            "65- Bir zarın tek atışında 4 gelme olasılığı nedir?",
            "66- Bir torbada 8 top (4 kırmızı, 4 mavi) bulunuyor. İlk çekilen topun kırmızı, ikincisinin mavi olma olasılığı nedir?",
            "67- Bir madeni para beş kez atılıyor. İlk üç atışın yazı gelme olasılığı nedir?",
            "68- Bir zar dört kez atılıyor. En az bir kez 6 gelme olasılığı nedir?",
            "69- İki zar atılıyor ve toplamlarının 5 gelme olasılığı nedir?",
            "70- Bir torbada 6 kırmızı, 4 mavi top var. İlk çekilen topun mavi olma olasılığı nedir?",
            "71- Bir zarın üç kez atılmasında en az iki kez 5 gelme olasılığı nedir?",
            "72- Bir desteden çekilen bir kartın vale olma olasılığı nedir?",
            "73- Bir zarın tek atışında 1 veya 2 gelme olasılığı nedir?",
            "74- Bir zar üç kez atıldığında, ilk iki atışta 6 gelme olasılığı nedir?",
            "75- Bir torbada 4 kırmızı, 3 mavi ve 3 sarı top var. İlk çekilen topun sarı olma olasılığı nedir?",
            "76- İki zar atıldığında toplamlarının 4 gelme olasılığı nedir?",
            "77- Bir madeni para üç kez atıldığında en az iki kez yazı gelme olasılığı nedir?",
            "78- Bir desteden çekilen ilk üç kartın hepsinin kupa olma olasılığı nedir?",
            "79- Bir torbada 5 altın ve 5 gümüş madalya var. İki madalya çekildiğinde her ikisinin de gümüş olma olasılığı nedir?",
            "80- Bir zarın dört kez atılmasında hiç 1 gelmeme olasılığı nedir?",
            "81- İki zar atılıyor, birinin 3 diğerinin 4 gelme olasılığı nedir?",
            "82- Bir kutuda 5 kırmızı, 5 mavi ve 10 yeşil kalem var. İlk çekilen kalem mavi olma olasılığı nedir?",
            "83- Bir torbada 7 mavi ve 3 yeşil top bulunuyor. Üç top çekildiğinde hepsinin mavi olma olasılığı nedir?",
            "84- Bir zarın iki kez atılmasında, ilk atışta 4 ve ikinci atışta daha düşük bir sayı gelme olasılığı nedir?",
            "85- Bir desteden çekilen üç kartın her birinin farklı takımdan olma olasılığı nedir?",
            "86- Bir zarın iki kez atılması durumunda, ikisinde de 1 gelme olasılığı nedir?",
            "87- Bir torbada 3 kırmızı, 7 mavi ve 5 yeşil top var. İlk çekilen topun yeşil olma olasılığı nedir?",
            "88- İki zar atıldığında toplamlarının 11 gelme olasılığı nedir?",
            "89- Bir futbol takımının bir maçta en az iki gol atma olasılığı, maç başına 1.5 gol ortalaması varsa nedir? (Poisson dağılımı gerektirir.)",
            "90- Bir torbada 8 kırmızı ve 12 mavi top bulunuyor. İki top çekildiğinde ikisinin de farklı renklerde olma olasılığı nedir?",
            "91- Bir zar üç kez atılıyor. İlk iki atışta aynı, üçüncü atışta farklı bir sayı gelme olasılığı nedir?",
            "92- Bir desteden çekilen bir kartın sinek olma ve değerinin 10 olma olasılığı nedir?",
            "93- Bir torbada 4 siyah, 6 beyaz top var. İki top çekildiğinde en az birinin siyah olma olasılığı nedir?",
            "94- Bir futbol maçında bir takımın ilk yarıda gol atma ve ikinci yarıda gol atamama olasılığı nedir?",
            "95- İki zar atıldığında, birinin çift diğerinin tek gelme olasılığı nedir?",
            "96- Bir zarın tek atışında 3'ten büyük bir sayı gelme olasılığı nedir?",
            "97- Bir torbada 20 top (10 kırmızı, 5 mavi, 5 yeşil) bulunuyor. İki top çekildiğinde her ikisinin de aynı renk olma olasılığı nedir?",
            "98- Bir madeni para üç kez atılıyor. İlk iki atış tura, üçüncü atış yazı gelme olasılığı nedir?",
            "99- Bir kutuda 4 kırmızı, 6 mavi ve 5 yeşil kalem var. İlk çekilen kalem yeşil olma olasılığı nedir?",
            "100- İki zar atıldığında toplamlarının 8 gelme olasılığı nedir?",
            "101- Bir zarın tek atışında 3 veya daha az gelme olasılığı nedir?",
            "102- Bir torbada 4 siyah, 3 beyaz top varken rastgele bir topun siyah olma olasılığı nedir?",
            "103- Üç zar atılıyor, ilk iki zarın toplamı 6, üçüncü zarın 4'ten büyük gelme olasılığı nedir?",
            "104- Bir zar beş kez atıldığında en az dört kez 6 gelme olasılığı nedir?",
            "105- Bir desteden çekilen ilk dört kartın farklı takımlardan (kupa, karo, sinek, maça) olma olasılığı nedir?",
            "106- İki madeni para atılıyor ve her iki atışta da yazı gelme olasılığı nedir?",
            "107- Bir zar iki kez atılıyor, ilk atış 3'ten büyük, ikinci atış 3'ten küçük gelme olasılığı nedir?",
            "108- Bir torbada 2 altın, 2 gümüş ve 6 bronz madalya var. İki madalya çekildiğinde her ikisinin de gümüş olma olasılığı nedir?",
            "109- İki zar atıldığında toplamlarının 3 gelme olasılığı nedir?",
            "110- Bir zarın dört kez atılmasında her seferinde farklı sayı gelme olasılığı nedir?",
            "111- Bir torbada 3 kırmızı, 7 mavi top var. İki top çekildiğinde ikisinin de mavi olma olasılığı nedir?",
            "112- İki madeni para atılıyor ve ikisi de tura gelme olasılığı nedir?",
            "113- Bir zarın beş kez atılmasında hiç 2 gelmeme olasılığı nedir?",
            "114- Bir zar iki kez atılıyor, toplamlarının çift sayı olma olasılığı nedir?",
            "115- Bir desteden çekilen bir kartın maça veya as olma olasılığı nedir?",
            "116- Bir kutuda 3 kırmızı, 7 mavi kalem var. Rastgele bir kalem çekme olasılığı nedir?",
            "117- Bir zarın tek atışında 1 veya 6 gelme olasılığı nedir?",
            "118- İki zar atılıyor, her ikisinin de 3'ten büyük gelme olasılığı nedir?",
            "119- Bir torbada 8 mavi, 2 yeşil top bulunuyor. İki top çekildiğinde her ikisinin de yeşil olma olasılığı nedir?",
            "120- Bir zarın iki kez atılmasında her iki atışta da 4'ten büyük gelme olasılığı nedir?",
            "121- Bir torbada 10 top (5 kırmızı, 5 mavi) bulunuyor. Üç top çekildiğinde en az iki topun kırmızı olma olasılığı nedir?",
            "122- Bir zarın üç kez atılmasında her atışta farklı sayı gelme olasılığı nedir?",
            "123- Bir madeni para beş kez atılıyor. Tüm atışların aynı yüz (tura veya yazı) gelme olasılığı nedir?",
            "124- İki zar atılıyor, birinin 2 diğerinin 5 gelme olasılığı nedir?",
			"125- Bir torbada 6 mavi, 5 siyah, 4 kırmızı top vardır. Torbadan rastgele bir top çekersek, seçilen topun siyah olma olasılığı nedir?",
			"126- 2 zar aynı anda masanın üzerine atılıyor. Üste gelen yüzeylerinin aynı sayı olma olasılığı nedir?",
			"127- 2 madeni para aynı anda masanın üzerine atılıyor. Üste gelen yüzeylerinin tura gelme olasılığı nedir?",
			"128- Bir torbada 9 mavi, 7 siyah, 4 sarı top vardır. Torbadan rastgele bir top çekersek, seçilen topun siyah olmama olasılığı nedir?",
			"129- 4 erkek ve 2 kız öğrenci bir tiyatro salonunda bir sırada yan yana oturacaklardır. Kızların bir arada oturma olasılığı nedir?",
			"130- 3 kız, 6 erkek öğrencinin olduğu bir gruptan iki öğrenci seçilecektir. Seçilen 1. öğrencinin kız, 2. öğrencinin erkek olması olasılığı nedir?",
			"131- Bir torbada aynı büyüklükte 2 mavi, 4 kırmızı ve 5 siyah top vardır. Geri konulmamak şartıyla torbadan 2 top çekiliyor. Bu topların ikisinin de siyah olma olasılığı nedir?",
			"132- Bir torbada 1'den 9'a kadar numaralandırılmış 9 bilye vardır. Torbadan geri atılmaksızın ard arda iki bilye çekersek, topların tek numaralı çıkma olasılığı nedir?",
			"133- Bir zar ve bir madeni para aynı anda masanın üzerine atılırsa, paranın yazı ve zarın tek numaralı yüzünün üste gelmesi olasılığı nedir?",
			"134- Bir torbada 4 beyaz, 3 mavi top vardır. Torbaya geri atılmamak koşulu ile arka arkaya 2 top çekersek, ikisinin de mavi olma olasılığı nedir?",
			"135- Havaya atılan bir zarın 0 gelme olasılığı nedir?",
            "136- Bir torbada 4 beyaz, 3 mavi, 2 sarı top vardır. Torbaya geri atılmamak koşulu ile arka arkaya 3 top çekiliyor. 1. topun beyaz, 2. topun mavi, 3. topun sarı renkli olma olasılığı edir?",
            "137- 6 yüzlü hilesiz iki zardan birincisinde 2 sayısı 3 olarak, ikincisinde 1 sayısı 4 olarak değiştiriliyor.",
            "138- 504 sayısının pozitif bölenleri arasından rastgele seçilen bir sayının 13'ten küçük olma olasılığı kaçtır?",
            "139- 1-100 aralığındaki tam sayılar arasından rastgele bir sayı seçiliyor. Bu sayının 3'e ve 4'e tam bölünen bir sayı olma olasılığı nedir?",
            "140- 1-100 aralığındaki tam sayılar arasından rastgele bir sayı seçiliyor. Bu sayının 3'e veya 4'e tam bölünen bir sayı olma olasılığı nedir?",
            "141- Rastgele seçilen üç basamaklı bir pozitif tam sayının karesi alındığında elde edilen sayının birler basamağının 4 olma olasılığı kaçtır?",
            "142- 61! sayısının pozitif bölenleri arasından rastgele seçilen bir sayının çift sayı olma olasılığı kaçtır?",
            "143- 4 basamaklı palindromik sayılar arasından rastgele seçilen bir sayının 9'a tam bölünme olasılığı nedir?",
            "144- İki basamaklı pozitif tam sayılar arasından rastgele seçilen bir sayının basamakları toplamının bir tam sayınınn küpü olma olasılığı nedir?",
			"145- Bir zar peş peşe iki kez atıldığında ilk zarın ikinciden büyük gelme olasılığı nedir?",
            "146- Altı yüzünden birinde 1, ikisinde 2, üçünde 3 rakamı bulunan iki zar atılıyor. Bu iki zarın aynı gelme olasılığı kaçtır?",
            "147- Hileli bir zarın çift sayı gelme olasılığı tek sayı gelme olasılığının 2 katıdır. Bu zar 2 kere atıldığında gelen sayıların toplamının tek sayı olma olasılığı kaçtır?",
            "148- Alp elindeki madeni parayı 2 kez, Bora elindeki madeni parayı 3 kez atıyor. İki arkadaşa aynı sayıda tura gelme olasılığı kaçtır?",
            "149- Bir zar 3 kez atılıyor ve gelen rakamların soldan sağa doğru yan yana yazılmasıyla 3 basamaklı sayılar oluşturuluyor. Bu şekilde oluşturulan bir sayının 3'e tam bölünme olasılığı nedir?",
            "150- Ufuk aynı anda 4 zar atıyor ve gelen sayıların çarpımını alıyor. Elde ettiği çarpımın 8'e tam bölünüyor olma olasılığı kaçtır?",
			"151- Rastgele seçilen iki basamaklı iki pozitif tam sayının toplamının 65 olma olasılığı kaçtır?",
            "152- Bir kalem kutusunda 4 kurşun , 3 mavi ve 1 kırmızı kalem bulunmaktadır.Kalem kutusundan rasgele alınan bir kalemin mavi olma olasılığı kaçtır?",
            "153- Bir olaydaki her bir olası durumun ( çıktının ) olasılığı eşit ise bu olaya eş olasılıklı olay denir. Bu ifade doğru mudur yanlış mıdır?",
            "154- 21'den 30'a kadar on sayının yazılı olduğu kağıtların olduğu torbadan seçilen kağıdın tek sayı olma olasılığı , çift sayı olma olasılığından fazladır. Yukarıdaki ifade doğru mudur yanlış  mıdır?",
            "155- Bir okuldaki öğretmen ve öğrencilerin isimlerinin yazılı olduğu listeden rastgele seçim yapıldığında seçilen ismin öğrenci olma olasılığı daha yüksektir. Yukarıdaki ifade doğru mudur yanlış mıdır?",
            "156- Sayıların yazılı olduğu kağıtların olduğu torbadan , torbada bulunan 13'ün seçilme olasılığı 1/10. Buna göre bu torbada en az kaç sayı vardır?",
            "157- Musa seyahat aracını bir bilgisayar programı ile rastgele seçecektir.Programda uçak, gemi, otobüs, otomobil ve tren vardır. Buna göre programın treni seçme olasılığı kaçtır?",
			"158- Bir olayın olma olasılığı 2 olabilir. Yukarıdaki ifade doğru mudur yanlış mıdır?",
            "159- Bir olayın olma olasılığı ile olmama olasılığının toplamı 1'dir. Yukarıdaki ifade doğru mudur yanlış mıdır?",
            "160- Atılan bir madeni paranın tura gelme olasılığı 1/2 ve yazı gelme olasılığı da 2'dir. İfade doğru mudur yanlış mıdır?",
            "161- RAMAZANDA ORUÇ kelimelerindeki harfler kağıtlara yazılmış ve bir torbaya atılmıştır. a ve b birer doğal sayı olmak üzere , alınan bir kağıdın A harfi olma olasılığı kaçtır?",
            "162- Bir sınıftaki 37 öğrencinin 11'inde cep telefonu bulunmaktadır.Ayağa kaldırılan bir öğrencinin cep telefonunun olmama olasılığı kaçtır?",
            "163- Bir mağazanın sattığı televizyonların %15'i bozuktur. Bu mağazadan televizyon alan Adem'in saatinin bozuk olma olasılığı a/20 olduğuna göre kaçtır?",
            "164- Bir kelimede bulunan harfler kağıtlara yazılmış ve bir torbaya atılmıştır.Alınan bir harfin E harfi olma olasılığı 3/8'dir. En az kaç e harfi vardır?",
            "165- 1 tanesi kırmızı 7 tanesi beyaz olan topun bulunduğu bir torbadan bir top almada alınan topun kırmızı olasılığı 1/8 ve kırmızı olma olasılığı 7/8 ifadesi doğru mudur?",
            "166- 1 tane portakal 4 tane elmanın bulunduğu bir tabaktan alınan meyvenin portakal olma olasılığı 1/5 olmama olasılığı 4/5 ifadesi doğru mu?",
            "167- Bir kitaplıkta 7 hikaye , 9 şiir ve 6 test kitabı bulunmaktadır.Kitaplıktan rasgele alınan bir kitabın şiir kitabı olmama olasılığı kaçtır?",
            "168- Golcünün kaleye şut çekmesi olayınında iki olası durum (çıktı) vardır. Yukarıdaki ifade doğru mudur yanlış mıdır?",
            "169- Bir basketçinin topu potaya atması olayında basket olma olasılığı ile basket olmama olasılığı eşittir. İfade doğru mudur yanlış mıdır?",
            "170- Bir okuldaki öğretmen ve öğrencilerin isimlerinin yazılı olduğu listede kayıtlı öğrenci Elif'in seçilme olasılığın 1/850'dir. Öğretmen ve öğrencilerin toplamı en az kaçtır?",
            "171- Alfabedeki bazı harflerin yazılı olduğu kağıtların olduğu torbadan seçilen kağıdın h harfi olma olasılığı 1/20. En az kaç harf vardır?",
            "172- Bir vazoda 5 tane gül 7 tane lale vardır.Bunlardan bir tanesi işaretlenmiştir. Gözü kapalı olarak vazodan seçilen çiçeğin işaretli olan olma olasılığı kaçtır?",
            "173- Bir kalem kutusunda 4 kurşun , 3 mavi ve 1 kırmızı kalem bulunmaktadır.Kalem kutusundan rasgele alınan bir kalemin mavi kalem olmama olasılığı kaçtır?",
            "174- Bir kitaplıkta 7 hikaye , 9 şiir ve 6 test kitabı bulunmaktadır. Kitaplıktan rasgele alınan bir kitabın şiir kitabı olma olasılığı kaçtır?",
            "175- 40 satır yazı bulunan bir kağıtta en önemli satır 10.satırdır.Rastgele işaretlenen bir satırın bu önemli satır olma olasılığı 1/39 ve önemli satır olmama olasılığı da 38/39. İfade  doğru mu?",
            "176- Eşit şansa sahip bir olayda her bir çıktının (olası durum) olasılık değeri 1/olası durum'dur. İfade doğru mu?",
            "177- A'dan z'ye harflerin yazılı olduğu kağıtların olduğu torbadan seçilen kağıdın ünlü harf olma olasılığı ile ünsüz harf  olma olasılığı eşittir.",
			"178- Bir madeni paranın atılmasında iki olası durum (çıktı) vardır.",
            "179- NAMAZ kelimesini oluşturan harfler kağıtlara yazılıp torbaya atılmıştır.Torbadan çekilen harfin A olması olayının olası  durumları ikidir.",
            "180- 5 mavi , 7 kırmızı ve 2 sarı topun bulunduğu bir torbadan bir top çekilmesi olayının olası durumları kaç tanedir?",
            "181- Basketçinin topu potaya atmasında basket olma olasılığı 1/2 ve basket olma olasılığı da 1/2 ifadesi doğru mudur?",
			"182- 4 elma , 5 portakal ve 2 ayva olan bir meyve sepetinden elma alma olayının kaç çıktı vardır?",
			"183- Bir soruda doğru mudur yanlış mıdır denildiğinde doğru cevap verme olasılığı kaçtır?",
			"184- Bir soruda 4 şık verildiğinde doğru cevap verilme olasılığı kaçtır?",
			"185- Bir ailenin 3 çocuğu vardır. Biri kız olduğuna göre diğerlerinin erkek olma olasılığı?",
			"186- Tavla zarı atıldığında 5 gelme olasılığı kaçtır?",
			"187- 2 zar atılıyor. Toplamının 7 gelme olasılığı kaçtır?",
			"188- Bir torbada 3 kırmızı, 5 beyaz top vardır. Kırmızı top olma olasılığı?",
			"189- Bir torbada 3 kırmızı, 5 beyaz top vardır. Beyaz olma olasılığı?",
			"190- Bir A olayının olma olasılığı aşağıdakilerden hangisi olamaz?",
            "191- Bir torbada 6 mavi, 5 siyah, 4 kırmızı top vardır. Torbadan rastgele bir top çekersek, seçilen topun siyah olma olasılığı nedir?",
            "192- Bir torbada 4 sarı, 3 mavi ve 2 yeşil top bulunmaktadır. Bir top çekildiğinde sarı top çekilme olasılığı nedir?",
            "193- Bir kutuda 3 kırmızı, 2 beyaz ve 5 siyah kalem vardır. Rastgele çekilen bir kalemin beyaz olma olasılığı nedir?",
            "194- Bir zarın tek atışında 4'ten büyük bir sayı gelme olasılığı nedir?",
            "195- İki zar atıldığında, her iki zarın da çift sayı gelme olasılığı nedir?",
            "196- Bir torbada 7 mavi ve 3 kırmızı top bulunuyor. İki top çekildiğinde her ikisinin de mavi olma olasılığı nedir?",
            "197- Bir torbada 8 top (5 siyah, 3 beyaz) bulunuyor. İki top çekildiğinde her ikisinin de beyaz olma olasılığı nedir?",
            "198- Bir zarın üç kez atılması durumunda, en az bir kez 6 gelme olasılığı nedir?",
            "199- Bir torbada 10 kırmızı ve 5 yeşil top bulunuyor. Rastgele çekilen bir topun kırmızı olma olasılığı nedir?",
            "200- Bir kutuda 6 mavi ve 4 yeşil kalem bulunmaktadır. İki kalem çekildiğinde her ikisinin de mavi olma olasılığı nedir?"
        };

        private string[] _cevaplar = {"6/36 -> 1/6", "26/52 -> 1/2", "1/4", "7599/1000 -> %75.99", "1/2","3/9 -> 1/3","1/3","5/8","2/10 -> 1/5","3/4 -> %75","2/3","1/6 -> %16,67","1/13 -> %7.69","5/84","1/2 -> %50",
        "1/17 -> %5.88","4/9 -> %44.44","1/2 -> %50","%78.26","4/9 -> %44.44","4/36 -> 1/9","4/13 -> %30.77","13/18 -> %72.22","1/6 -> %16.67","13/102 -> %12.75","0, 1/'dir.","1/6", "6/36 -> 1/6","2/9",
        "1/8", "3/8","3/120 -> 1/40","1/36","2/9","1-(5/6)^5","1/2","1","1/4","0.8³ = 0.343","40","1/36","1/3","Kırmızı için 3/6; mavi için 2/6; sarı için 1/6","1/8","3.8².0.2+0.8³ = 0.896","1/3","11/15","1/5",
        "1/6","Kırmızı: 4/10, mavi 6/10.","2/9","1/200 -> 0,01","1/1296","1/3", "63/100 -> 0.063","(1/6) * (1/6) = 1/36", "9/2000","1/36","(1/2) * (1/2) * (1/2) = 1/8","13/52 = 1/4","2/10 * 1/9 = 1/45",
        "(1/6) * (1/6) * (1/6) = 1/216","1","27/1000","1/6","(4/8) * (4/7) = 1/4","(1/2)^3 = 1/8","671/1296","4/36 = 1/9","4/10 = 2/5","2/27","4/52 -> 1/13","1/3"," 1/36","3/10","3/36 -> 1/12","3*(1/2)^3 + (1/2)^3 = 1/2",
        "(13/52) * (12/51) * (11/50) = 13/1005","2/9","625/1296","1/18","1/4","(7/10) * (6/9) * (5/8) = 7/24","1/12","507/1205","1/36","1/3","1/18","4422/10000","48/95","25/216","1/52","2/3","2491/10000","1/4",
        "1/2","13/38","1/8","1/3","5/36","1/2","4/7","5/18","11/1296","21/100","1/4","1/4","1/45","1/18","720/1296","21/45","1/4"," (5/6)^5","1/2","16/52","1","1/3","1/4","1/45","1/9","10/21","120/216","2*(1/2)^5",
        "1/18","1/3","1/6","1/4","13/20","1/3","1/4","2/11","5/18","1/4","1/7","0","1/21","4/9","3/8","2/25","1/2","1/5","56/57","1/9","1/10","5/12","7/18","1/9","5/16","1/3",
		"25/48","46/90.90","3/8","Doğru","Yanlış","Doğru","10","1/5","Yanlıştır.","Doğru","Yanlış","17","26/37","4","3","Doğru","Doğru","13/22","Doğru","Doğru","850","20","1/12","5/8",
        "9/22", "Yanlış","Doğru","Yanlış","Doğru","Doğru","14","Doğru","4","1/2","1/4","3/7","1/6","1/6","3/8","5/8","5/2","1/3","4/9","1/5","1/3","1/4","7/15","3/28","91/216","2/3","1/3"};
        
        private void Sorular_Load(object sender, EventArgs e)
        {
            labelCevap.Visible = false;
            rdAll.Visible = false;
            rdOnly.Visible = false;

            //ArrayList Assignments;
            _sorularArray = new ArrayList();
            _cevaplarArray = new ArrayList();
            _sorularArray.AddRange(_sorular);
            _cevaplarArray.AddRange(_cevaplar);


            SoruGetir();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {   
            SoruGetir();
        }

        private void ShowAnswersButton_Click(object sender, EventArgs e)
        {
            if (!_showAnswer)
            {
                ShowAnswersButton.Text = "Cevapları Kapat";
                labelCevap.Visible = true;
                _showAnswer = true;
            }

            else
            {
                ShowAnswersButton.Text = "Cevapları Göster";
                labelCevap.Visible = false;
                _showAnswer = false;
            }
        }

        private void SoruGetir()
        {
            int randomSayi;
            _random = new Random();
            randomSayi = _random.Next(0, _sorularArray.Count);

            // For bug search.
            if (_sorularArray.Count != _cevaplarArray.Count)
            {
                MessageBox.Show("Soru ve cevap sayısı eşit değil!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (_sorularArray.Count == 0 || _cevaplarArray.Count == 0)
            {
                MessageBox.Show("Soru kalmadı.", "Tüm Soruları Bitirdiniz :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelSoru.Text = "Sayın Karahanlı zekanızı ve azminizi takdir ediyor!";
                labelCevap.Text = "Sayın Karahanlı zekanızı ve azminizi takdir ediyor!";
                RefreshButton.Enabled = false;
                ShowAnswersButton.Enabled = false;
                return;
            }

            if (randomSayi >= 0 && randomSayi <= _sorularArray.Count)
            {
                labelSoru.Text = _sorularArray[randomSayi].ToString();
                labelCevap.Text = "Cevap: "+ _cevaplarArray[randomSayi];
                _sorularArray.RemoveAt(randomSayi);
                _cevaplarArray.RemoveAt(randomSayi);
            }
        }

        private void TextBuyut_Click(object sender, EventArgs e)
        {
            BPP();
        }

        private void TextKucult_Click(object sender, EventArgs e)
        {
            BPN();
        }

        private void TextSifirla_Click(object sender, EventArgs e)
        {
            BPZ();
        }

        private void PrintQuestionsButton_Click(object sender, EventArgs e)
        {
            if (_showExportError)
            {
                _showExportError = false;
            }

            else
            {
                if (rdAll.Checked == false && rdOnly.Checked == false)
                {
                    MessageBox.Show("Hiçbir Dışa Aktarma Seçeneği Seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else 
                {
                    _showExportError = true;
                }
            }

            rdAll.Visible = true;
            rdOnly.Visible = true;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Belgeleri|*.docx";

            if (rdAll.Checked == true)
            {
                sfd.Title = "Tüm Soruları Word Dosyası Olarak Kaydet";
                sfd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(sfd.FileName))
                {
                    try
                    {
                        Word.Application word = new Word.Application();
                        word.Visible = true;

                        string exportData = string.Join("\n\n", _sorular);

                        Word.Document doc = word.Documents.Add();
                        doc.Content.Text = exportData;

                        // Save Word File.
                        object fileName = sfd.FileName;
                        doc.SaveAs2(ref fileName);

                        // Word Object is Equated to 0;
                        word = null;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (rdOnly.Checked == true)
            {
                sfd.Title = "Geçerli Soruyu Word Dosyası Olarak Kaydet";
                sfd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(sfd.FileName))
                {
                    try
                    {
                        Word.Application word = new Word.Application();
                        word.Visible = true;
                        
                        string exportData = labelSoru.Text;

                        Word.Document doc = word.Documents.Add();
                        doc.Content.Text = exportData;

                        object fileName = sfd.FileName;
                        doc.SaveAs2(ref fileName);
                        
                        word = null;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BPP()
        {
            _standardLabelFont += 1;
            labelSoru.Font = new Font("Microsoft Sans Serif", _standardLabelFont, FontStyle.Bold);
            labelCevap.Font = new Font("Microsoft Sans Serif", _standardLabelFont, FontStyle.Bold);

            if (_standardLabelFont >= 5)
            {
                TextKucult.Enabled = true;

                //  y +=10 px;

                //_refreshButtonX += _slipRate;
                _refreshButtonY += _slipRate;
                //_showAnswerButtonX += _slipRate;
                _showAnswerButtonY += _slipRate;
                //_printQuestionButtonX += _slipRate;
                _printQuestionButtonY += _slipRate;
                _textBuyutButtonX += _slipRate;
                _textBuyutButtonY += _slipRate;
                _textKucultButtonX += _slipRate;
                _textKucultButtonY += _slipRate;
                _textSifirlaButtonX += _slipRate;
                _textSifirlaButtonY += _slipRate;
                //_rdAllButtonX += _slipRate;
                _rdAllButtonY += _slipRate;
                //_rdOnlyButtonX += _slipRate;
                _rdOnlyButtonY += _slipRate;
                _thisX += _slipRate;
                _thisY += _slipRate;

                this.Size = new System.Drawing.Size(_thisX, _thisY);
                RefreshButton.Location = new Point(_refreshButtonX, _refreshButtonY);
                ShowAnswersButton.Location = new Point(_showAnswerButtonX, _showAnswerButtonY);
                PrintQuestionsButton.Location = new Point(_printQuestionButtonX, _printQuestionButtonY);
                TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
                TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
                TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
                rdAll.Location = new Point(_rdAllButtonX, _rdAllButtonY);
                rdOnly.Location = new Point(_rdOnlyButtonX, _rdOnlyButtonY);
            }
        }

        private void BPN()
        {
            if (_standardLabelFont == 12)
            {
                TextKucult.Enabled = false;
                MessageBox.Show("Daha fazla küçültülme yapılamaz.", "Maksimum Küçültmeye Ulaştınız.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                _standardLabelFont -= 1;
                labelSoru.Font = new Font("Microsoft Sans Serif", _standardLabelFont, FontStyle.Bold);
                labelCevap.Font = new Font("Microsoft Sans Serif", _standardLabelFont, FontStyle.Bold);

                //_refreshButtonX -= _slipRate;
                _refreshButtonY -= _slipRate;
                //_showAnswerButtonX -= _slipRate;
                _showAnswerButtonY -= _slipRate;
                //_printQuestionButtonX -= _slipRate;
                _printQuestionButtonY -= _slipRate;
                _textBuyutButtonX -= _slipRate;
                _textBuyutButtonY -= _slipRate;
                _textKucultButtonX -= _slipRate;
                _textKucultButtonY -= _slipRate;
                _textSifirlaButtonX -= _slipRate;
                _textSifirlaButtonY -= _slipRate;
                //_rdAllButtonX -= _slipRate;   
                _rdAllButtonY -= _slipRate;
                //_rdOnlyButtonX -= _slipRate;
                _rdOnlyButtonY -= _slipRate;
                _thisX -= _slipRate +5;
                _thisY -= _slipRate;

                this.Size = new System.Drawing.Size(_thisX, _thisY);
                RefreshButton.Location = new Point(_refreshButtonX, _refreshButtonY);
                ShowAnswersButton.Location = new Point(_showAnswerButtonX, _showAnswerButtonY);
                PrintQuestionsButton.Location = new Point(_printQuestionButtonX, _printQuestionButtonY);
                TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
                TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
                TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
                rdAll.Location = new Point(_rdAllButtonX, _rdAllButtonY);
                rdOnly.Location = new Point(_rdOnlyButtonX, _rdOnlyButtonY);
            }
        }

        private void BPZ()
        {
            _standardLabelFont = 12;
            labelSoru.Font = new Font("Microsoft Sans Serif", _standardLabelFont, FontStyle.Bold);
            labelCevap.Font = new Font("Microsoft Sans Serif", _standardLabelFont, FontStyle.Bold);
            TextKucult.Enabled = true;

            // this max-min res. && listbox position;
            _standardLabelFont = 12;
            _refreshButtonX = 12; _refreshButtonY = 204;
            _printQuestionButtonX = 239; _printQuestionButtonY = 204;
            _showAnswerButtonX = 120; _showAnswerButtonY = 204;
            _textBuyutButtonX = 564; _textBuyutButtonY = 208;
            _textKucultButtonX = 635; _textKucultButtonY = 208;
            _textSifirlaButtonX = 706; _textSifirlaButtonY = 208;
            _rdAllButtonX = 362; _rdAllButtonY = 204;
            _rdOnlyButtonX = 362; _rdOnlyButtonY = 239;
            _thisX = 807; _thisY = 307;

            this.Size = new System.Drawing.Size(_thisX, _thisY);
            RefreshButton.Location = new Point(_refreshButtonX, _refreshButtonY);
            ShowAnswersButton.Location = new Point(_showAnswerButtonX, _showAnswerButtonY);
            PrintQuestionsButton.Location = new Point(_printQuestionButtonX, _printQuestionButtonY);
            TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
            TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
            TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
            rdAll.Location = new Point(_rdAllButtonX, _rdAllButtonY);
            rdOnly.Location = new Point(_rdOnlyButtonX, _rdOnlyButtonY);
        }
    }
}