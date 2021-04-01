using System;

Practical java_work1 = new Practical("http://...", "http://..."); // создаем несколько пз и лекций
Practical java_work2 = new Practical("http://...", "http://...");
Practical java_work3 = new Practical("http://...", "http://...");
Practical java_work4 = new Practical("http://...", "http://...");
Practical java_work5 = new Practical("http://...", "http://...");

Lecture java_lecture = new Lecture("Maven");

Training java = new Training("Java", java_work1, java_work2); // создаем тренинг

java.Add(java_work3); // добавляем еще пз, но уже через метод
java.Add(java_work4);
java.Add(java_work5);

Console.WriteLine(java.Show()); // выводим содержимое тренинга

Console.WriteLine("Содержит только пз: " + java.IsPractical()); // проверяем содержит ли тренинг только пз

java.Add(java_lecture); // теперь добавим одну лекцию

Console.WriteLine(java.Show()); //снова выводим содержимое тренинга

Console.WriteLine("Содержит только пз: " + java.IsPractical()); // и снова проверяем содержит ли тренинг только пз

Training java_new = java.Clone(); // теперь клонируем наш тренинг 

Console.WriteLine("Содержит только пз: " + java_new.IsPractical()); // сравниваем копию с оригиналом

Console.WriteLine(java_new.Show());

Training java_null = new Training(null); // проверяю метод show на экземпляре без лекций и пз

Console.WriteLine(java_null.Show());