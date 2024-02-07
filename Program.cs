using Kodlama_io_Pair4.Entities;

Instructor teacher1 = new Instructor(1, "Engin Demirog");
Instructor teacher2 = new Instructor(2, "Halit Enes Kalayci");

Category category = new Category(1, "Programlama");

Price price = new Price(1, 0);

Courses courses1 = new Courses(1, "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, " +
    "döküman ve duyurularını buradan yapacağız.", 1, 1);


Courses course2 = new Courses(2, "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
"Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", 2, 1);

Courses course3 = new Courses(3, "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
"Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", 1, 1);

Courses course4 = new Courses(4, "Yazılım Geliştirici Yetiştirme Kampı(JavaScript)",
"1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", 1, 1);

Courses course5 = new Courses(5, "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
"2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", 1, 1);

Courses course6 = new Courses(6, "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
"2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", 1, 1);

Courses course7 = new Courses(7, "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
"Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", 1, 1);

Courses course8 = new Courses(8, "Programlamaya Giriş için Temel Kurs",
"PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.", 1, 1);


Console.WriteLine(courses1);