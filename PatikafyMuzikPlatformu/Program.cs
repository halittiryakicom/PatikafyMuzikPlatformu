using PatikafyMuzikPlatformu;

//Sanatçı nesneleri ütretildi ve listeye eklendi
List <Song> musics = new List <Song> ()
{
    new Song 
    {
        FullName = "Ajda Pekkan", MusicGenre = "Pop", Year = 1968, Sales = 20000500
    },
    new Song
    {
        FullName = "Sezen Aksu", MusicGenre = "Türk Halk Müziği / Pop", Year = 1971, Sales = 10000500
    },
    new Song
    {
        FullName = "Funda Arar", MusicGenre = "Pop", Year = 1999, Sales = 3000500
    },
    new Song
    {
        FullName = "Sertap Erener", MusicGenre = "Pop", Year = 1994, Sales = 5005000
    },
    new Song
    {
        FullName = "Sıla", MusicGenre = "Pop", Year = 2009, Sales = 3000500
    },
    new Song
    {
        FullName = "Serdar Ortaç", MusicGenre = "Pop", Year = 1994, Sales = 10000500
    },
    new Song
    {
        FullName = "Tarkan", MusicGenre = "Pop", Year = 1992, Sales = 40000500
    },
    new Song
    {
        FullName = "Hande Yener", MusicGenre = "Pop", Year = 1999, Sales = 7000500
    },
    new Song
    {
        FullName = "Hadise", MusicGenre = "Pop", Year = 2005, Sales = 5000500
    },
    new Song
    {
        FullName = "Gülben Ergen", MusicGenre = "Pop / Türk Halk Müziği", Year = 1997, Sales = 10000500
    },
    new Song
    {
        FullName = "Neşet Ertaş", MusicGenre = "Türk Halk Müziği / Türk Sanat Müziği", Year = 1960, Sales = 2000500
    }
};

//Adı S ile başyalan sanatçılar
Console.WriteLine("---------- Adı S ile başlayan sanatçılar ----------");
var sName = musics.Where(item => item.FullName.ToLower().StartsWith('s')).ToList();
foreach (var s in sName)
{
    Console.WriteLine($"Sanatçı adı: {s.FullName}");
}

//albüm Satışları 10 milyon üzerinde olan sanatçılar
Console.WriteLine("---------- Adı S ile başlayan sanatçılar ----------");
var sales = musics.Where(item => item.Sales > 10000000);
foreach (var s in sales)
{
    Console.WriteLine($"Sanatçı Adı: {s.FullName}, Satış Miktarı: {s.Sales}");
}

//2000 yılı öncesi çıkış yapmış ve pop müzik yapan sanatçılar
Console.WriteLine("---------- 2000 yılı öncesi çıkış yapmış ve pop müzik yapan sanatçılar ----------");
var result = musics.Where(item => item.Year < 2000 && item.MusicGenre.Contains("Pop")).GroupBy(item => item.Year).ToList();
foreach (var s in result.OrderBy(item => item.Key))
{
    Console.WriteLine($"Çıkış Yılı: {s.Key}");
    foreach (var item in s.OrderBy(item => item.FullName))
    {
        Console.WriteLine($"{item.FullName}");
    }
}

//En çok albüm satan şarkıcı
Console.WriteLine("---------- En çok albüm satan sanatçı ----------");
var salesMax = musics.OrderByDescending(item => item.Sales).FirstOrDefault();
Console.WriteLine($"En çok satış yapan sanatçı: {salesMax.FullName}, Satış miktarı: {salesMax.Sales}");

//En yeni ve en eski çıkış yapan sanatçı
Console.WriteLine("---------- En yeni ve en eski çıkış yapan sanatçı ----------");
var newOldMusucian = musics.OrderBy(item => item.Year).ToList();
Console.WriteLine($"En eski sanatçı: {newOldMusucian[0].FullName}, çıkış yılı: {newOldMusucian[0].Year}");
Console.WriteLine($"En yeni sanatçı: {newOldMusucian[newOldMusucian.Count-1].FullName}, çıkış yılı: {newOldMusucian[newOldMusucian.Count - 1].Year}");