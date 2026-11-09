// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");


// Console.WriteLine("Введите оценки по одной, для завершения введите -1:");
// int count = 0;
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество введённых оценок: {count}");


// int sum = 0;
// int count = 0;
// int maxGrade = int.MinValue;

// Console.WriteLine("Введите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1) {
//     sum += grade;
//     count++;

//     if (grade > maxGrade) {
//         maxGrade = grade;
//     }

//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0) {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Наибольшая оценка: {maxGrade}");
// } else {
//     Console.WriteLine("Оценок не было введено");
// }


// string correctPassword = "qwerty123";
// int failedAttempts = 0;

// while (true) {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword) {
//         Console.WriteLine("Доступ разрешён");
//         Console.WriteLine($"Количество неудачных попыток: {failedAttempts}");
//         break;
//     }

//     failedAttempts++;
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }


// string correctPassword = "qwerty123";
// int failedAttempts = 0;

// while (true) {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword) {
//         Console.WriteLine("Доступ разрешён");
//         Console.WriteLine($"Количество неудачных попыток: {failedAttempts}");
//         break;
//     }

//     failedAttempts++;
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }


// string answer;

// do {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранён");


// int count = 0;

// Console.WriteLine("Введите имена учеников. Для завершения введите «конец»:");

// string name = Console.ReadLine();

// while (name != "конец") {
//     count++;
//     name = Console.ReadLine();
// }

// Console.WriteLine($"Количество введённых имён: {count}");


// while (true) {
//     Console.Write("Введите целое число: ");
//     int number = int.Parse(Console.ReadLine());

//     if (number % 7 == 0) {
//         Console.WriteLine("Найдено!");
//         break;
//     }
// }


// int sum = 0;

// Console.WriteLine("Введите целые числа. Для завершения введите 0:");

// int number = int.Parse(Console.ReadLine());

// while (number != 0) {
//     if (number > 0) {
//         sum += number;
//     }

//     number = int.Parse(Console.ReadLine());
// }

// Console.WriteLine($"Сумма положительных чисел: {sum}");


// double sum = 0;

// for (int day = 1; day <= 7; day++) {
//     Console.Write($"Введите температуру за день {day}: ");
//     double temperature = double.Parse(Console.ReadLine());

//     sum += temperature;
// }

// double average = sum / 7;

// Console.WriteLine($"Средняя температура за неделю: {average}");


// string correctPin = "1234";
// int attempts = 0;
// bool accessGranted = false;

// while (attempts < 3) {
//     Console.Write("Введите PIN-код: ");
//     string pin = Console.ReadLine();

//     if (pin == correctPin) {
//         accessGranted = true;
//         break;
//     }

//     attempts++;
// }

// if (accessGranted) {
//     int total = 0;

//     Console.WriteLine("Введите сумму снятия. Для завершения введите 0:");

//     int amount = int.Parse(Console.ReadLine());

//     while (amount != 0) {
//         total += amount;
//         amount = int.Parse(Console.ReadLine());
//     }

//     Console.WriteLine($"Общая снятая сумма: {total}");
// } else {
//     Console.WriteLine("Карта заблокирована");
// }