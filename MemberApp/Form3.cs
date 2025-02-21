using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberApp
{
    public partial class Form3 : Form
    {
        public string ilListesi = "1 Adana Aladağ\r\n2 Adana Ceyhan\r\n3 Adana Çukurova\r\n4 Adana Feke\r\n5 Adana İmamoğlu\r\n6 Adana Karaisalı\r\n7 Adana Karataş\r\n8 Adana Kozan\r\n9 Adana Pozantı\r\n10 Adana Saimbeyli\r\n11 Adana Sarıçam\r\n12 Adana Seyhan\r\n13 Adana Tufanbeyli\r\n14 Adana Yumurtalık\r\n15 Adana Yüreğir\r\n\r\n1 Adıyaman Besni\r\n2 Adıyaman Çelikhan\r\n3 Adıyaman Gerger\r\n4 Adıyaman Gölbaşı\r\n5 Adıyaman Kahta\r\n6 Adıyaman Merkez\r\n7 Adıyaman Samsat\r\n8 Adıyaman Sincik\r\n9 Adıyaman Tut\r\n\r\n1 Afyonkarahisar Başmakçı\r\n2 Afyonkarahisar Bayat\r\n3 Afyonkarahisar Bolvadin\r\n4 Afyonkarahisar Çay\r\n5 Afyonkarahisar Çobanlar\r\n6 Afyonkarahisar Dazkırı\r\n7 Afyonkarahisar Dinar\r\n8 Afyonkarahisar Emirdağ\r\n9 Afyonkarahisar Evciler\r\n10 Afyonkarahisar Hocalar\r\n11 Afyonkarahisar İhsaniye\r\n12 Afyonkarahisar İscehisar\r\n13 Afyonkarahisar Kızılören\r\n14 Afyonkarahisar Merkez\r\n15 Afyonkarahisar Sandıklı\r\n16 Afyonkarahisar Sinanpaşa\r\n17 Afyonkarahisar Şuhut\r\n18 Afyonkarahisar Sultandağı\r\n\r\n1 Ağrı Diyadin\r\n2 Ağrı Doğubayazıt\r\n3 Ağrı Eleşkirt\r\n4 Ağrı Hamur\r\n5 Ağrı Merkez\r\n6 Ağrı Patnos\r\n7 Ağrı Taşlıçay\r\n8 Ağrı Tutak\r\n\r\n1 Aksaray Ağaçören\r\n2 Aksaray Eskil\r\n3 Aksaray Gülağaç\r\n4 Aksaray Güzelyurt\r\n5 Aksaray Merkez\r\n6 Aksaray Ortaköy\r\n7 Aksaray Sarıyahşi\r\n8 Aksaray Sultanhanı\r\n\r\n1 Amasya Göynücek\r\n2 Amasya Gümüşhacıköy\r\n3 Amasya Hamamözü\r\n4 Amasya Merkez\r\n5 Amasya Merzifon\r\n6 Amasya Suluova\r\n7 Amasya Taşova\r\n\r\n1 Ankara Akyurt\r\n2 Ankara Altındağ\r\n3 Ankara Ayaş\r\n4 Ankara Bala\r\n5 Ankara Beypazarı\r\n6 Ankara Çamlıdere\r\n7 Ankara Çankaya\r\n8 Ankara Çubuk\r\n9 Ankara Elmadağ\r\n10 Ankara Etimesgut\r\n11 Ankara Evren\r\n12 Ankara Gölbaşı\r\n13 Ankara Güdül\r\n14 Ankara Haymana\r\n15 Ankara Kahramankazan\r\n16 Ankara Kalecik\r\n17 Ankara Keçiören\r\n18 Ankara Kızılcahamam\r\n19 Ankara Mamak\r\n20 Ankara Nallıhan\r\n21 Ankara Polatlı\r\n22 Ankara Pursaklar\r\n23 Ankara Şereflikoçhisar\r\n24 Ankara Sincan\r\n25 Ankara Yenimahalle\r\n\r\n1 Antalya Akseki\r\n2 Antalya Aksu\r\n3 Antalya Alanya\r\n4 Antalya Demre\r\n5 Antalya Döşemealtı\r\n6 Antalya Elmalı\r\n7 Antalya Finike\r\n8 Antalya Gazipaşa\r\n9 Antalya Gündoğmuş\r\n10 Antalya İbradı\r\n11 Antalya Kaş\r\n12 Antalya Kemer\r\n13 Antalya Kepez\r\n14 Antalya Konyaaltı\r\n15 Antalya Korkuteli\r\n16 Antalya Kumluca\r\n17 Antalya Manavgat\r\n18 Antalya Muratpaşa\r\n19 Antalya Serik\r\n\r\n1 Ardahan Çıldır\r\n2 Ardahan Damal\r\n3 Ardahan Göle\r\n4 Ardahan Hanak\r\n5 Ardahan Merkez\r\n6 Ardahan Posof\r\n\r\n1 Artvin Ardanuç\r\n2 Artvin Arhavi\r\n3 Artvin Borçka\r\n4 Artvin Hopa\r\n5 Artvin Kemalpaşa\r\n6 Artvin Merkez\r\n7 Artvin Murgul\r\n8 Artvin Şavşat\r\n9 Artvin Yusufeli\r\n\r\n1 Aydın Bozdoğan\r\n2 Aydın Buharkent\r\n3 Aydın Çine\r\n4 Aydın Didim\r\n5 Aydın Efeler\r\n6 Aydın Germencik\r\n7 Aydın İncirliova\r\n8 Aydın Karacasu\r\n9 Aydın Karpuzlu\r\n10 Aydın Koçarlı\r\n11 Aydın Köşk\r\n12 Aydın Kuşadası\r\n13 Aydın Kuyucak\r\n14 Aydın Nazilli\r\n15 Aydın Söke\r\n16 Aydın Sultanhisar\r\n17 Aydın Yenipazar\r\n\r\n1 Balıkesir Altıeylül\r\n2 Balıkesir Ayvalık\r\n3 Balıkesir Balya\r\n4 Balıkesir Bandırma\r\n5 Balıkesir Bigadiç\r\n6 Balıkesir Burhaniye\r\n7 Balıkesir Dursunbey\r\n8 Balıkesir Edremit\r\n9 Balıkesir Erdek\r\n10 Balıkesir Gömeç\r\n11 Balıkesir Gönen\r\n12 Balıkesir Havran\r\n13 Balıkesir İvrindi\r\n14 Balıkesir Karesi\r\n15 Balıkesir Kepsut\r\n16 Balıkesir Manyas\r\n17 Balıkesir Marmara\r\n18 Balıkesir Savaştepe\r\n19 Balıkesir Sındırgı\r\n20 Balıkesir Susurluk\r\n\r\n1 Bartın Amasra\r\n2 Bartın Kurucaşile\r\n3 Bartın Merkez\r\n4 Bartın Ulus\r\n1 Batman Beşiri\r\n2 Batman Gercüş\r\n3 Batman Hasankeyf\r\n4 Batman Kozluk\r\n5 Batman Merkez\r\n6 Batman Sason\r\n\r\n1 Bayburt Aydıntepe\r\n2 Bayburt Demirözü\r\n3 Bayburt Merkez\r\n\r\n1 Bilecik Bozüyük\r\n2 Bilecik Gölpazarı\r\n3 Bilecik İnhisar\r\n4 Bilecik Merkez\r\n5 Bilecik Osmaneli\r\n6 Bilecik Pazaryeri\r\n7 Bilecik Söğüt\r\n8 Bilecik Yenipazar\r\n\r\n1 Bingöl Adaklı\r\n2 Bingöl Genç\r\n3 Bingöl Karlıova\r\n4 Bingöl Kiğı\r\n5 Bingöl Merkez\r\n6 Bingöl Solhan\r\n7 Bingöl Yayladere\r\n8 Bingöl Yedisu\r\n\r\n1 Bitlis Adilcevaz\r\n2 Bitlis Ahlat\r\n3 Bitlis Güroymak\r\n4 Bitlis Hizan\r\n5 Bitlis Merkez\r\n6 Bitlis Mutki\r\n7 Bitlis Tatvan\r\n\r\n1 Burdur Ağlasun\r\n2 Burdur Altınyayla\r\n3 Burdur Bucak\r\n4 Burdur Çavdır\r\n5 Burdur Çeltikçi\r\n6 Burdur Gölhisar\r\n7 Burdur Karamanlı\r\n8 Burdur Kemer\r\n9 Burdur Merkez\r\n10 Burdur Tefenni\r\n11 Burdur Yeşilova\r\n\r\n1 Bursa Büyükorhan\r\n2 Bursa Gemlik\r\n3 Bursa Gürsu\r\n4 Bursa Harmancık\r\n5 Bursa İnegöl\r\n6 Bursa İznik\r\n7 Bursa Karacabey\r\n8 Bursa Keles\r\n9 Bursa Kestel\r\n10 Bursa Mudanya\r\n11 Bursa Mustafakemalpaşa\r\n12 Bursa Nilüfer\r\n13 Bursa Orhaneli\r\n14 Bursa Orhangazi\r\n15 Bursa Osmangazi\r\n16 Bursa Yenişehir\r\n17 Bursa Yıldırım\r\n\r\n1 Çanakkale Ayvacık\r\n2 Çanakkale Bayramiç\r\n3 Çanakkale Biga\r\n4 Çanakkale Bozcaada\r\n5 Çanakkale Çan\r\n6 Çanakkale Eceabat\r\n7 Çanakkale Ezine\r\n8 Çanakkale Gelibolu\r\n9 Çanakkale Gökçeada\r\n10 Çanakkale Lapseki\r\n11 Çanakkale Merkez\r\n12 Çanakkale Yenice\r\n\r\n1 Çankırı Atkaracalar\r\n2 Çankırı Bayramören\r\n3 Çankırı Çerkeş\r\n4 Çankırı Eldivan\r\n5 Çankırı Ilgaz\r\n6 Çankırı Kızılırmak\r\n7 Çankırı Korgun\r\n8 Çankırı Kurşunlu\r\n9 Çankırı Merkez\r\n10 Çankırı Orta\r\n11 Çankırı Şabanözü\r\n12 Çankırı Yapraklı\r\n\r\n1 Çorum Alaca\r\n2 Çorum Bayat\r\n3 Çorum Boğazkale\r\n4 Çorum Dodurga\r\n5 Çorum İskilip\r\n6 Çorum Kargı\r\n7 Çorum Laçin\r\n8 Çorum Mecitözü\r\n9 Çorum Merkez\r\n10 Çorum Oğuzlar\r\n11 Çorum Ortaköy\r\n12 Çorum Osmancık\r\n13 Çorum Sungurlu\r\n14 Çorum Uğurludağ\r\n\r\n1 Denizli Acıpayam\r\n2 Denizli Babadağ\r\n3 Denizli Baklan\r\n4 Denizli Bekilli\r\n5 Denizli Beyağaç\r\n6 Denizli Bozkurt\r\n7 Denizli Buldan\r\n8 Denizli Çal\r\n9 Denizli Çameli\r\n10 Denizli Çardak\r\n11 Denizli Çivril\r\n12 Denizli Güney\r\n13 Denizli Honaz\r\n14 Denizli Kale\r\n15 Denizli Merkezefendi\r\n16 Denizli Pamukkale\r\n17 Denizli Sarayköy\r\n18 Denizli Serinhisar\r\n19 Denizli Tavas\r\n\r\n1 Diyarbakır Bağlar\r\n2 Diyarbakır Bismil\r\n3 Diyarbakır Çermik\r\n4 Diyarbakır Çınar\r\n5 Diyarbakır Çüngüş\r\n6 Diyarbakır Dicle\r\n7 Diyarbakır Eğil\r\n8 Diyarbakır Ergani\r\n9 Diyarbakır Hani\r\n10 Diyarbakır Hazro\r\n11 Diyarbakır Kayapınar\r\n12 Diyarbakır Kocaköy\r\n13 Diyarbakır Kulp\r\n14 Diyarbakır Lice\r\n15 Diyarbakır Silvan\r\n16 Diyarbakır Sur\r\n17 Diyarbakır Yenişehir\r\n\r\n1 Düzce Akçakoca\r\n2 Düzce Çilimli\r\n3 Düzce Cumayeri\r\n4 Düzce Gölyaka\r\n5 Düzce Gümüşova\r\n6 Düzce Kaynaşlı\r\n7 Düzce Merkez\r\n8 Düzce Yığılca\r\n\r\n1 Edirne Enez\r\n2 Edirne Havsa\r\n3 Edirne İpsala\r\n4 Edirne Keşan\r\n5 Edirne Lalapaşa\r\n6 Edirne Meriç\r\n7 Edirne Merkez\r\n8 Edirne Süloğlu\r\n9 Edirne Uzunköprü\r\n\r\n1 Elazığ Ağın\r\n2 Elazığ Alacakaya\r\n3 Elazığ Arıcak\r\n4 Elazığ Baskil\r\n5 Elazığ Karakoçan\r\n6 Elazığ Keban\r\n7 Elazığ Kovancılar\r\n8 Elazığ Maden\r\n9 Elazığ Merkez\r\n10 Elazığ Palu\r\n11 Elazığ Sivrice\r\n\r\n1 Erzincan Çayırlı\r\n2 Erzincan İliç\r\n3 Erzincan Kemah\r\n4 Erzincan Kemaliye\r\n5 Erzincan Merkez\r\n6 Erzincan Otlukbeli\r\n7 Erzincan Refahiye\r\n8 Erzincan Tercan\r\n9 Erzincan Üzümlü\r\n\r\n1 Erzurum Aşkale\r\n2 Erzurum Aziziye\r\n3 Erzurum Çat\r\n4 Erzurum Hınıs\r\n5 Erzurum Horasan\r\n6 Erzurum İspir\r\n7 Erzurum Karaçoban\r\n8 Erzurum Karayazı\r\n9 Erzurum Köprüköy\r\n10 Erzurum Narman\r\n11 Erzurum Oltu\r\n12 Erzurum Olur\r\n13 Erzurum Palandöken\r\n14 Erzurum Pasinler\r\n15 Erzurum Pazaryolu\r\n16 Erzurum Şenkaya\r\n17 Erzurum Tekman\r\n18 Erzurum Tortum\r\n19 Erzurum Uzundere\r\n20 Erzurum Yakutiye\r\n\r\n1 Eskişehir Alpu\r\n2 Eskişehir Beylikova\r\n3 Eskişehir Çifteler\r\n4 Eskişehir Günyüzü\r\n5 Eskişehir Han\r\n6 Eskişehir İnönü\r\n7 Eskişehir Mahmudiye\r\n8 Eskişehir Mihalgazi\r\n9 Eskişehir Mihalıççık\r\n10 Eskişehir Odunpazarı\r\n11 Eskişehir Sarıcakaya\r\n12 Eskişehir Seyitgazi\r\n13 Eskişehir Sivrihisar\r\n14 Eskişehir Tepebaşı\r\n\r\n1 Gaziantep Araban\r\n2 Gaziantep İslahiye\r\n3 Gaziantep Karkamış\r\n4 Gaziantep Nizip\r\n5 Gaziantep Nurdağı\r\n6 Gaziantep Oğuzeli\r\n7 Gaziantep Şahinbey\r\n8 Gaziantep Şehitkamil\r\n9 Gaziantep Yavuzeli\r\n\r\n1 Giresun Alucra\r\n2 Giresun Bulancak\r\n3 Giresun Çamoluk\r\n4 Giresun Çanakçı\r\n5 Giresun Dereli\r\n6 Giresun Doğankent\r\n7 Giresun Espiye\r\n8 Giresun Eynesil\r\n9 Giresun Görele\r\n10 Giresun Güce\r\n11 Giresun Keşap\r\n12 Giresun Merkez\r\n13 Giresun Piraziz\r\n14 Giresun Şebinkarahisar\r\n15 Giresun Tirebolu\r\n16 Giresun Yağlıdere\r\n\r\n1 Gümüşhane Kelkit\r\n2 Gümüşhane Köse\r\n3 Gümüşhane Kürtün\r\n4 Gümüşhane Merkez\r\n5 Gümüşhane Şiran\r\n6 Gümüşhane Torul\r\n\r\n1 Hakkari Çukurca\r\n2 Hakkari Derecik\r\n3 Hakkari Merkez\r\n4 Hakkari Şemdinli\r\n5 Hakkari Yüksekova\r\n\r\n1 Hatay Altınözü\r\n2 Hatay Antakya\r\n3 Hatay Arsuz\r\n4 Hatay Belen\r\n5 Hatay Defne\r\n6 Hatay Dörtyol\r\n7 Hatay Erzin\r\n8 Hatay Hassa\r\n9 Hatay İskenderun\r\n10 Hatay Kırıkhan\r\n11 Hatay Kumlu\r\n12 Hatay Payas\r\n13 Hatay Reyhanlı\r\n14 Hatay Samandağ\r\n15 Hatay Yayladağı\r\n\r\n1 Iğdır Aralık\r\n2 Iğdır Karakoyunlu\r\n3 Iğdır Merkez\r\n4 Iğdır Tuzluca\r\n\r\n1 Isparta Aksu\r\n2 Isparta Atabey\r\n3 Isparta Eğirdir\r\n4 Isparta Gelendost\r\n5 Isparta Gönen\r\n6 Isparta Keçiborlu\r\n7 Isparta Merkez\r\n8 Isparta Şarkikaraağaç\r\n9 Isparta Senirkent\r\n10 Isparta Sütçüler\r\n11 Isparta Uluborlu\r\n12 Isparta Yalvaç\r\n13 Isparta Yenişarbademli\r\n\r\n1 İstanbul Adalar\r\n2 İstanbul Arnavutköy\r\n3 İstanbul Ataşehir\r\n4 İstanbul Avcılar\r\n5 İstanbul Bağcılar\r\n6 İstanbul Bahçelievler\r\n7 İstanbul Bakırköy\r\n8 İstanbul Başakşehir\r\n9 İstanbul Bayrampaşa\r\n10 İstanbul Beşiktaş\r\n11 İstanbul Beykoz\r\n12 İstanbul Beylikdüzü\r\n13 İstanbul Beyoğlu\r\n14 İstanbul Büyükçekmece\r\n15 İstanbul Çatalca\r\n16 İstanbul Çekmeköy\r\n17 İstanbul Esenler\r\n18 İstanbul Esenyurt\r\n19 İstanbul Eyüpsultan\r\n20 İstanbul Fatih\r\n21 İstanbul Gaziosmanpaşa\r\n22 İstanbul Güngören\r\n23 İstanbul Kadıköy\r\n24 İstanbul Kağıthane\r\n25 İstanbul Kartal\r\n26 İstanbul Küçükçekmece\r\n27 İstanbul Maltepe\r\n28 İstanbul Pendik\r\n29 İstanbul Sancaktepe\r\n30 İstanbul Sarıyer\r\n31 İstanbul Şile\r\n32 İstanbul Silivri\r\n33 İstanbul Şişli\r\n34 İstanbul Sultanbeyli\r\n35 İstanbul Sultangazi\r\n36 İstanbul Tuzla\r\n37 İstanbul Ümraniye\r\n38 İstanbul Üsküdar\r\n39 İstanbul Zeytinburnu\r\n\r\n1 İzmir Aliağa\r\n2 İzmir Balçova\r\n3 İzmir Bayındır\r\n4 İzmir Bayraklı\r\n5 İzmir Bergama\r\n6 İzmir Beydağ\r\n7 İzmir Bornova\r\n8 İzmir Buca\r\n9 İzmir Çeşme\r\n10 İzmir Çiğli\r\n11 İzmir Dikili\r\n12 İzmir Foça\r\n13 İzmir Gaziemir\r\n14 İzmir Güzelbahçe\r\n15 İzmir Karabağlar\r\n16 İzmir Karaburun\r\n17 İzmir Karşıyaka\r\n18 İzmir Kemalpaşa\r\n19 İzmir Kınık\r\n20 İzmir Kiraz\r\n21 İzmir Konak\r\n22 İzmir Menderes\r\n23 İzmir Menemen\r\n24 İzmir Narlıdere\r\n25 İzmir Ödemiş\r\n26 İzmir Seferihisar\r\n27 İzmir Selçuk\r\n28 İzmir Tire\r\n29 İzmir Torbalı\r\n30 İzmir Urla\r\n\r\n1 Kahramanmaraş Afşin\r\n2 Kahramanmaraş Andırın\r\n3 Kahramanmaraş Çağlayancerit\r\n4 Kahramanmaraş Dulkadiroğlu\r\n5 Kahramanmaraş Ekinözü\r\n6 Kahramanmaraş Elbistan\r\n7 Kahramanmaraş Göksun\r\n8 Kahramanmaraş Nurhak\r\n9 Kahramanmaraş Onikişubat\r\n10 Kahramanmaraş Pazarcık\r\n11 Kahramanmaraş Türkoğlu\r\n\r\n1 Karabük Eflani\r\n2 Karabük Eskipazar\r\n3 Karabük Merkez\r\n4 Karabük Ovacık\r\n5 Karabük Safranbolu\r\n6 Karabük Yenice\r\n\r\n1 Karaman Ayrancı\r\n2 Karaman Başyayla\r\n3 Karaman Ermenek\r\n4 Karaman Kazımkarabekir\r\n5 Karaman Merkez\r\n6 Karaman Sarıveliler\r\n\r\n1 Kars Akyaka\r\n2 Kars Arpaçay\r\n3 Kars Digor\r\n4 Kars Kağızman\r\n5 Kars Merkez\r\n6 Kars Sarıkamış\r\n7 Kars Selim\r\n8 Kars Susuz\r\n\r\n1 Kastamonu Abana\r\n2 Kastamonu Ağlı\r\n3 Kastamonu Araç\r\n4 Kastamonu Azdavay\r\n5 Kastamonu Bozkurt\r\n6 Kastamonu Çatalzeytin\r\n7 Kastamonu Cide\r\n8 Kastamonu Daday\r\n9 Kastamonu Devrekani\r\n10 Kastamonu Doğanyurt\r\n11 Kastamonu Hanönü\r\n12 Kastamonu İhsangazi\r\n13 Kastamonu İnebolu\r\n14 Kastamonu Küre\r\n15 Kastamonu Merkez\r\n16 Kastamonu Pınarbaşı\r\n17 Kastamonu Şenpazar\r\n18 Kastamonu Seydiler\r\n19 Kastamonu Taşköprü\r\n20 Kastamonu Tosya\r\n\r\n1 Kayseri Akkışla\r\n2 Kayseri Bünyan\r\n3 Kayseri Develi\r\n4 Kayseri Felahiye\r\n5 Kayseri Hacılar\r\n6 Kayseri İncesu\r\n7 Kayseri Kocasinan\r\n8 Kayseri Melikgazi\r\n9 Kayseri Özvatan\r\n10 Kayseri Pınarbaşı\r\n11 Kayseri Sarıoğlan\r\n12 Kayseri Sarız\r\n13 Kayseri Talas\r\n14 Kayseri Tomarza\r\n15 Kayseri Yahyalı\r\n16 Kayseri Yeşilhisar\r\n\r\n1 Kilis Elbeyli\r\n2 Kilis Merkez\r\n3 Kilis Musabeyli\r\n4 Kilis Polateli\r\n1 Kırıkkale Bahşılı\r\n2 Kırıkkale Balışeyh\r\n3 Kırıkkale Çelebi\r\n4 Kırıkkale Delice\r\n5 Kırıkkale Karakeçili\r\n6 Kırıkkale Keskin\r\n7 Kırıkkale Merkez\r\n8 Kırıkkale Sulakyurt\r\n9 Kırıkkale Yahşihan\r\n\r\n1 Kırklareli Babaeski\r\n2 Kırklareli Demirköy\r\n3 Kırklareli Kofçaz\r\n4 Kırklareli Lüleburgaz\r\n5 Kırklareli Merkez\r\n6 Kırklareli Pehlivanköy\r\n7 Kırklareli Pınarhisar\r\n8 Kırklareli Vize\r\n\r\n1 Kırşehir Akçakent\r\n2 Kırşehir Akpınar\r\n3 Kırşehir Boztepe\r\n4 Kırşehir Çiçekdağı\r\n5 Kırşehir Kaman\r\n6 Kırşehir Merkez\r\n7 Kırşehir Mucur\r\n\r\n1 Kocaeli Başiskele\r\n2 Kocaeli Çayırova\r\n3 Kocaeli Darıca\r\n4 Kocaeli Derince\r\n5 Kocaeli Dilovası\r\n6 Kocaeli Gebze\r\n7 Kocaeli Gölcük\r\n8 Kocaeli İzmit\r\n9 Kocaeli Kandıra\r\n10 Kocaeli Karamürsel\r\n11 Kocaeli Kartepe\r\n12 Kocaeli Körfez\r\n\r\n1 Konya Ahırlı\r\n2 Konya Akören\r\n3 Konya Akşehir\r\n4 Konya Altınekin\r\n5 Konya Beyşehir\r\n6 Konya Bozkır\r\n7 Konya Çeltik\r\n8 Konya Cihanbeyli\r\n9 Konya Çumra\r\n10 Konya Derbent\r\n11 Konya Derebucak\r\n12 Konya Doğanhisar\r\n13 Konya Emirgazi\r\n14 Konya Ereğli\r\n15 Konya Güneysınır\r\n16 Konya Hadim\r\n17 Konya Halkapınar\r\n18 Konya Hüyük\r\n19 Konya Ilgın\r\n20 Konya Kadınhanı\r\n21 Konya Karapınar\r\n22 Konya Karatay\r\n23 Konya Kulu\r\n24 Konya Meram\r\n25 Konya Sarayönü\r\n26 Konya Selçuklu\r\n27 Konya Seydişehir\r\n28 Konya Taşkent\r\n29 Konya Tuzlukçu\r\n30 Konya Yalıhüyük\r\n31 Konya Yunak\r\n\r\n1 Kütahya Altıntaş\r\n2 Kütahya Aslanapa\r\n3 Kütahya Çavdarhisar\r\n4 Kütahya Domaniç\r\n5 Kütahya Dumlupınar\r\n6 Kütahya Emet\r\n7 Kütahya Gediz\r\n8 Kütahya Hisarcık\r\n9 Kütahya Merkez\r\n10 Kütahya Pazarlar\r\n11 Kütahya Şaphane\r\n12 Kütahya Simav\r\n13 Kütahya Tavşanlı\r\n\r\n1 Malatya Akçadağ\r\n2 Malatya Arapgir\r\n3 Malatya Arguvan\r\n4 Malatya Battalgazi\r\n5 Malatya Darende\r\n6 Malatya Doğanşehir\r\n7 Malatya Doğanyol\r\n8 Malatya Hekimhan\r\n9 Malatya Kale\r\n10 Malatya Kuluncak\r\n11 Malatya Pütürge\r\n12 Malatya Yazıhan\r\n13 Malatya Yeşilyurt\r\n\r\n1 Manisa Ahmetli\r\n2 Manisa Akhisar\r\n3 Manisa Alaşehir\r\n4 Manisa Demirci\r\n5 Manisa Gölmarmara\r\n6 Manisa Gördes\r\n7 Manisa Kırkağaç\r\n8 Manisa Köprübaşı\r\n9 Manisa Kula\r\n10 Manisa Salihli\r\n11 Manisa Sarıgöl\r\n12 Manisa Saruhanlı\r\n13 Manisa Şehzadeler\r\n14 Manisa Selendi\r\n15 Manisa Soma\r\n16 Manisa Turgutlu\r\n17 Manisa Yunusemre\r\n\r\n1 Mardin Artuklu\r\n2 Mardin Dargeçit\r\n3 Mardin Derik\r\n4 Mardin Kızıltepe\r\n5 Mardin Mazıdağı\r\n6 Mardin Midyat\r\n7 Mardin Nusaybin\r\n8 Mardin Ömerli\r\n9 Mardin Savur\r\n10 Mardin Yeşilli\r\n\r\n1 Mersin Akdeniz\r\n2 Mersin Anamur\r\n3 Mersin Aydıncık\r\n4 Mersin Bozyazı\r\n5 Mersin Çamlıyayla\r\n6 Mersin Erdemli\r\n7 Mersin Gülnar\r\n8 Mersin Mezitli\r\n9 Mersin Mut\r\n10 Mersin Silifke\r\n11 Mersin Tarsus\r\n12 Mersin Toroslar\r\n13 Mersin Yenişehir\r\n\r\n1 Muğla Bodrum\r\n2 Muğla Dalaman\r\n3 Muğla Datça\r\n4 Muğla Fethiye\r\n5 Muğla Kavaklıdere\r\n6 Muğla Köyceğiz\r\n7 Muğla Marmaris\r\n8 Muğla Menteşe\r\n9 Muğla Milas\r\n10 Muğla Ortaca\r\n11 Muğla Seydikemer\r\n12 Muğla Ula\r\n13 Muğla Yatağan\r\n\r\n1 Muş Bulanık\r\n2 Muş Hasköy\r\n3 Muş Korkut\r\n4 Muş Malazgirt\r\n5 Muş Merkez\r\n6 Muş Varto\r\n\r\n1 Nevşehir Acıgöl\r\n2 Nevşehir Avanos\r\n3 Nevşehir Derinkuyu\r\n4 Nevşehir Gülşehir\r\n5 Nevşehir Hacıbektaş\r\n6 Nevşehir Kozaklı\r\n7 Nevşehir Merkez\r\n8 Nevşehir Ürgüp\r\n\r\n1 Niğde Altunhisar\r\n2 Niğde Bor\r\n3 Niğde Çamardı\r\n4 Niğde Çiftlik\r\n5 Niğde Merkez\r\n6 Niğde Ulukışla\r\n\r\n1 Ordu Akkuş\r\n2 Ordu Altınordu\r\n3 Ordu Aybastı\r\n4 Ordu Çamaş\r\n5 Ordu Çatalpınar\r\n6 Ordu Çaybaşı\r\n7 Ordu Fatsa\r\n8 Ordu Gölköy\r\n9 Ordu Gülyalı\r\n10 Ordu Gürgentepe\r\n11 Ordu İkizce\r\n12 Ordu Kabadüz\r\n13 Ordu Kabataş\r\n14 Ordu Korgan\r\n15 Ordu Kumru\r\n16 Ordu Mesudiye\r\n17 Ordu Perşembe\r\n18 Ordu Ulubey\r\n19 Ordu Ünye\r\n\r\n1 Osmaniye Bahçe\r\n2 Osmaniye Düziçi\r\n3 Osmaniye Hasanbeyli\r\n4 Osmaniye Kadirli\r\n5 Osmaniye Merkez\r\n6 Osmaniye Sumbas\r\n7 Osmaniye Toprakkale\r\n\r\n1 Rize Ardeşen\r\n2 Rize Çamlıhemşin\r\n3 Rize Çayeli\r\n4 Rize Derepazarı\r\n5 Rize Fındıklı\r\n6 Rize Güneysu\r\n7 Rize Hemşin\r\n8 Rize İkizdere\r\n9 Rize İyidere\r\n10 Rize Kalkandere\r\n11 Rize Merkez\r\n12 Rize Pazar\r\n\r\n1 Sakarya Adapazarı\r\n2 Sakarya Akyazı\r\n3 Sakarya Arifiye\r\n4 Sakarya Erenler\r\n5 Sakarya Ferizli\r\n6 Sakarya Geyve\r\n7 Sakarya Hendek\r\n8 Sakarya Karapürçek\r\n9 Sakarya Karasu\r\n10 Sakarya Kaynarca\r\n11 Sakarya Kocaali\r\n12 Sakarya Pamukova\r\n13 Sakarya Sapanca\r\n14 Sakarya Serdivan\r\n15 Sakarya Söğütlü\r\n16 Sakarya Taraklı\r\n\r\n1 Samsun 19 Mayıs\r\n2 Samsun Alaçam\r\n3 Samsun Asarcık\r\n4 Samsun Atakum\r\n5 Samsun Ayvacık\r\n6 Samsun Bafra\r\n7 Samsun Canik\r\n8 Samsun Çarşamba\r\n9 Samsun Havza\r\n10 Samsun İlkadım\r\n11 Samsun Kavak\r\n12 Samsun Ladik\r\n13 Samsun Salıpazarı\r\n14 Samsun Tekkeköy\r\n15 Samsun Terme\r\n16 Samsun Vezirköprü\r\n17 Samsun Yakakent\r\n\r\n1 Şanlıurfa Akçakale\r\n2 Şanlıurfa Birecik\r\n3 Şanlıurfa Bozova\r\n4 Şanlıurfa Ceylanpınar\r\n5 Şanlıurfa Eyyübiye\r\n6 Şanlıurfa Halfeti\r\n7 Şanlıurfa Haliliye\r\n8 Şanlıurfa Harran\r\n9 Şanlıurfa Hilvan\r\n10 Şanlıurfa Karaköprü\r\n11 Şanlıurfa Siverek\r\n12 Şanlıurfa Suruç\r\n13 Şanlıurfa Viranşehir\r\n\r\n1 Siirt Baykan\r\n2 Siirt Eruh\r\n3 Siirt Kurtalan\r\n4 Siirt Merkez\r\n5 Siirt Pervari\r\n6 Siirt Şirvan\r\n7 Siirt Tillo\r\n\r\n1 Sinop Ayancık\r\n2 Sinop Boyabat\r\n3 Sinop Dikmen\r\n4 Sinop Durağan\r\n5 Sinop Erfelek\r\n6 Sinop Gerze\r\n7 Sinop Merkez\r\n8 Sinop Saraydüzü\r\n9 Sinop Türkeli\r\n\r\n1 Şırnak Beytüşşebap\r\n2 Şırnak Cizre\r\n3 Şırnak Güçlükonak\r\n4 Şırnak İdil\r\n5 Şırnak Merkez\r\n6 Şırnak Silopi\r\n7 Şırnak Uludere\r\n\r\n1 Sivas Akıncılar\r\n2 Sivas Altınyayla\r\n3 Sivas Divriği\r\n4 Sivas Doğanşar\r\n5 Sivas Gemerek\r\n6 Sivas Gölova\r\n7 Sivas Gürün\r\n8 Sivas Hafik\r\n9 Sivas İmranlı\r\n10 Sivas Kangal\r\n11 Sivas Koyulhisar\r\n12 Sivas Merkez\r\n13 Sivas Şarkışla\r\n14 Sivas Suşehri\r\n15 Sivas Ulaş\r\n16 Sivas Yıldızeli\r\n17 Sivas Zara\r\n\r\n1 Tekirdağ Çerkezköy\r\n2 Tekirdağ Çorlu\r\n3 Tekirdağ Ergene\r\n4 Tekirdağ Hayrabolu\r\n5 Tekirdağ Kapaklı\r\n6 Tekirdağ Malkara\r\n7 Tekirdağ Marmaraereğlisi\r\n8 Tekirdağ Muratlı\r\n9 Tekirdağ Saray\r\n10 Tekirdağ Şarköy\r\n11 Tekirdağ Süleymanpaşa\r\n\r\n1 Tokat Almus\r\n2 Tokat Artova\r\n3 Tokat Başçiftlik\r\n4 Tokat Erbaa\r\n5 Tokat Merkez\r\n6 Tokat Niksar\r\n7 Tokat Pazar\r\n8 Tokat Reşadiye\r\n9 Tokat Sulusaray\r\n10 Tokat Turhal\r\n11 Tokat Yeşilyurt\r\n12 Tokat Zile\r\n\r\n1 Trabzon Akçaabat\r\n2 Trabzon Araklı\r\n3 Trabzon Arsin\r\n4 Trabzon Beşikdüzü\r\n5 Trabzon Çarşıbaşı\r\n6 Trabzon Çaykara\r\n7 Trabzon Dernekpazarı\r\n8 Trabzon Düzköy\r\n9 Trabzon Hayrat\r\n10 Trabzon Köprübaşı\r\n11 Trabzon Maçka\r\n12 Trabzon Of\r\n13 Trabzon Ortahisar\r\n14 Trabzon Şalpazarı\r\n15 Trabzon Sürmene\r\n16 Trabzon Tonya\r\n17 Trabzon Vakfıkebir\r\n18 Trabzon Yomra\r\n\r\n1 Tunceli Çemişgezek\r\n2 Tunceli Hozat\r\n3 Tunceli Mazgirt\r\n4 Tunceli Merkez\r\n5 Tunceli Nazımiye\r\n6 Tunceli Ovacık\r\n7 Tunceli Pertek\r\n8 Tunceli Pülümür\r\n\r\n1 Uşak Banaz\r\n2 Uşak Eşme\r\n3 Uşak Karahallı\r\n4 Uşak Merkez\r\n5 Uşak Sivaslı\r\n6 Uşak Ulubey\r\n\r\n1 Van Bahçesaray\r\n2 Van Başkale\r\n3 Van Çaldıran\r\n4 Van Çatak\r\n5 Van Edremit\r\n6 Van Erciş\r\n7 Van Gevaş\r\n8 Van Gürpınar\r\n9 Van İpekyolu\r\n10 Van Muradiye\r\n11 Van Özalp\r\n12 Van Saray\r\n13 Van Tuşba\r\n\r\n1 Yalova Altınova\r\n2 Yalova Armutlu\r\n3 Yalova Çiftlikköy\r\n4 Yalova Çınarcık\r\n5 Yalova Merkez\r\n6 Yalova Termal\r\n\r\n1 Yozgat Akdağmadeni\r\n2 Yozgat Aydıncık\r\n3 Yozgat Boğazlıyan\r\n4 Yozgat Çandır\r\n5 Yozgat Çayıralan\r\n6 Yozgat Çekerek\r\n7 Yozgat Kadışehri\r\n8 Yozgat Merkez\r\n9 Yozgat Saraykent\r\n10 Yozgat Sarıkaya\r\n11 Yozgat Şefaatli\r\n12 Yozgat Sorgun\r\n13 Yozgat Yenifakılı\r\n14 Yozgat Yerköy\r\n\r\n1 Zonguldak Alaplı\r\n2 Zonguldak Çaycuma\r\n3 Zonguldak Devrek\r\n4 Zonguldak Ereğli\r\n5 Zonguldak Gökçebey\r\n6 Zonguldak Kilimli\r\n7 Zonguldak Kozlu\r\n8 Zonguldak Merkez";
        public List<Member> members { get; set; }
        private isUsers userManager;
        public Form3(isUsers manager)
        {
            InitializeComponent();
            members = getMembers();
            userManager = manager;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; dataGridView1.ColumnHeadersHeight = 30;

            button2.FlatAppearance.BorderSize = 0; button3.FlatAppearance.BorderSize = 0;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(29, 28, 40); dataGridView1.DefaultCellStyle.ForeColor = Color.White; dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(8, 133, 114);
            var members = this.members;
            dataGridView1.DataSource = members;
        }
        private List<Member> getMembers()
        {
            var list = new List<Member>();
            list.Add(new Member()
            {
                Güncelleme = "16.08.2024 18:19:17",
                İsim = "Ahmet Yılmaz",
                TelefonNo = 2421514949,
                Mail = "ahmetyılmaz@gmail.com",
                Şifre = "ahmet123",
                Cinsiyet = "Erkek",
                Adres = "Bilecik Gölpazarı 12. sokak cami arkası yaman apartman."
            });
            return list;
        }

        private void AddMember(Member member)
        {
            // Mevcut üyeleri listeye ekleyin
            members.Add(member);

            // DataGridView'i güncelleyin
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = members;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label30.Visible = false;
            label11.ForeColor = Color.Green;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isTrue = true;

            if (!IsFullName(textBox1.Text))
            {
                label25.Visible = true;
                isTrue = false;
            }
            else
            {
                label25.Visible = false;
            }

            if (!IsValidEmail(textBox3.Text))
            {
                label24.Visible = true;
                isTrue = false;
            }
            else
            {
                label24.Visible = false;
            }

            if (textBox2.Text.Length < 10 || textBox2.Text.StartsWith("0"))
            {
                label26.Visible = true;
                isTrue = false;
            }
            else
            {
                label26.Visible = false;
            }

            if (textBox4.Text.Length < 3)
            {
                label23.Visible = false;
                label22.Visible = true;
                isTrue = false;
            }
            else
            {
                label23.Visible = true;
                label22.Visible = false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                label27.Visible = true;
                isTrue = false;
            }
            else
            {
                label27.Visible = false;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                label28.Visible = true;
                isTrue = false;
            }
            else
            {
                label28.Visible = false;
            }

            if (textBox5.Text.Length < 3)
            {
                label29.Visible = true;
                isTrue = false;
            }
            else
            {
                label29.Visible = false;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                label30.Visible = true;
                isTrue = false;
            }
            else
            {
                label30.Visible = false;
            }

            if (!checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.Red;
                isTrue = false;
            }
            else
            {
                checkBox1.ForeColor = Color.WhiteSmoke;
            }

            if (isTrue)
            {
                string cinsiyet;
                if (checkBox1.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }

                var newMember = new Member()
                {
                    Güncelleme = DateTime.Now.ToString(),
                    İsim = textBox1.Text,
                    TelefonNo = long.Parse(textBox2.Text),
                    Mail = textBox3.Text,
                    Şifre = textBox4.Text,
                    Cinsiyet = cinsiyet,
                    Adres = comboBox1.SelectedItem.ToString() + " " + comboBox2.SelectedItem.ToString() + " " + textBox5.Text,
                };

                AddMember(newMember);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                radioButton1.Checked = false;
                radioButton2.Checked = false;

                label11.ForeColor = Color.Red;
            }
            else
            {
                return;
            }
        }

        public bool IsFullName(string value)
        {
            string[] parts = value.Trim().Split(' ');
            return parts.Length >= 2;
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Regex pattern for validating email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public string GetDistricts(string cityName)
        {
            comboBox2.SelectedIndex = -1;
            string[] lines = ilListesi.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> districts = new List<string>();

            foreach (var line in lines)
            {
                if (line.Contains(cityName))
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length > 1 && parts[1] == cityName)
                    {
                        districts.Add(parts[2]);
                    }
                }
            }

            string finalstr = string.Join("-", districts);

            string[] items = finalstr.Split('-');
            comboBox2.Items.Clear();
            foreach (string item in items)
            {
                comboBox2.Items.Add(item);
            }
            return finalstr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                label27.Visible = false;
                label15.ForeColor = Color.Green;

                string selectedValue = comboBox1.SelectedItem.ToString();
                string districtsString = GetDistricts(selectedValue);
            }
            else
            {
                label15.ForeColor = Color.Red;
            }
        }

        private void comboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            ComboBox cb = sender as ComboBox;

            if (cb == null) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
            }

            // Metni çizmek için
            if (e.Index >= 0 && e.Index < cb.Items.Count)
            {
                e.Graphics.DrawString(cb.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label30.Visible = false;
            label11.ForeColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsFullName(textBox1.Text))
            {
                label25.Visible = false;
                label13.ForeColor = Color.Green;
            }
            else
            {
                label13.ForeColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(textBox3.Text))
            {
                label24.Visible = false;
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.ForeColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((textBox2.Text.Length == 10) && (!textBox2.Text.StartsWith("0")))
            {
                label26.Visible = false;
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(textBox4.Text == "")
            {
                label6.ForeColor = Color.Red;
                label22.Visible = false;
                label23.Visible = false;
            }
            else if (textBox4.Text.Length < 3)
            {
                label22.Visible = false;
                label6.ForeColor = Color.Red;
                label23.Visible = true;
                label23.Text = "Geçersiz.";
                label23.ForeColor = Color.Red;
            }
            else if ((textBox4.Text.Length == 3))
            {
                label22.Visible = false;
                label6.ForeColor = Color.Green;
                label23.Visible = true;
                label23.Text = "Zayıf.";
                label23.ForeColor = Color.Red;
            }
            else if ((textBox4.Text.Length > 3) && (textBox4.Text.Length < 7))
            {
                label22.Visible = false;
                label6.ForeColor = Color.Green;
                label23.Visible = true;
                label23.Text = "Orta.";
                label23.ForeColor = Color.Orange;
            }
            else if (textBox4.Text.Length >= 8)
            {
                label22.Visible = false;
                label6.ForeColor = Color.Green;
                label23.Visible = true;
                label23.Text = "Güçlü.";
                label23.ForeColor = Color.Green;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                label28.Visible = false;
                label12.ForeColor = Color.Green;
            }
            else
            {
                label12.ForeColor = Color.Red;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 3)
            {
                label29.Visible = false;
                label8.ForeColor = Color.Green;
            }
            else
            {
                label8.ForeColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4.UseSystemPasswordChar)
            {
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(100, 100, 100), 1))
            {
                // Üst kenar
                e.Graphics.DrawLine(pen, 0, 0, panel5.Width - 1, 0);
                // Sol kenar
                e.Graphics.DrawLine(pen, 0, 0, 0, panel5.Height - 1);
                // Alt kenar
                e.Graphics.DrawLine(pen, 0, panel5.Height - 1, panel5.Width - 1, panel5.Height - 1);
                // Sağ kenar
                e.Graphics.DrawLine(pen, panel5.Width - 1, 0, panel5.Width - 1, panel5.Height - 1);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userManager);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userManager);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userManager);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            label17.ForeColor = Color.FromArgb(8, 133, 114);
            panel7.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.WhiteSmoke;
            panel7.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(60, 68, 83);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(39, 47, 57);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }
    }
}
