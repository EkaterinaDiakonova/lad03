Console.WriteLine("Банковский счет");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500;
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200 ;
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05;
Console.WriteLine($"После начисления 5%: {balance}");

balance /= 2;
Console.WriteLine($"После деления пополам: {balance}");

Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
Console.WriteLine($"После этого weekNumber = {weekNumber}");

Console.WriteLine();
Console.WriteLine("Практическая ловушка");

int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");

Console.WriteLine();
Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;
Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");


Console.WriteLine();
Console.WriteLine("Логические операторы");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;

bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;
Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
Console.WriteLine($"Нет долгов: {isDebtFree}");

Console.WriteLine();
Console.WriteLine("Короткое замыкание");

bool CheckAndPrint(string label, bool value) { Console.WriteLine($"Вычисляется: {label}"); return value;}

Console.WriteLine("Проверяем && (первый операнд false):");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

Console.WriteLine();
Console.WriteLine("Проверяем || (первый операнд true):");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Результат: {resultOr}");

Console.WriteLine();
Console.WriteLine("Приоритет операций");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4 = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4 = {resultWithParens}");
bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5 > 3 && 2 < 4 || false = {logicResult}");
Console.WriteLine($"(5 > 3 && 2 < 4) || false = {logicResultParens}");

Console.WriteLine();
Console.WriteLine("Приёмная комиссия");

Console.Write("Введите средний балл аттестата: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Введите баллы за экзамен (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.Write("Есть льгота? (1 - да, 0 - нет): ");
int benefitInput = int.Parse(Console.ReadLine());
bool hasBenefit = (benefitInput == 1);
bool hasGoodCertificate = averageGrade >= 4.0;
bool hasGoodExam = examScore >= 60;
bool iseligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;
double totalScore = averageGrade * 10; 
totalScore += examScore;

Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
Console.WriteLine($"Льгота: {hasBenefit}");
Console.WriteLine($"Проходит по правилам: {iseligibleByRules}");
Console.WriteLine($"Итоговый балл: {totalScore}");

Console.WriteLine("Задание 1");
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
bool isEven = num % 2 == 0;
Console.WriteLine($"Число {num} четное: {isEven}");

Console.WriteLine("Задание 2");

int coins = 7;
int gotCoins = coins++; // coins++ сначала отдает старое значение (7), а потом увеличивает его на 1
Console.WriteLine($"coins++ вернул:{gotCoins}, стало coins = {coins}"); // gotCoins = 7, а coins стал 8

int num10 = 3;
int Numbe = ++num10; // ++num10 сначала увеличивает num10(3 => 4), а потом отдает новое значение
Console.WriteLine($"++num10 вернул:{Numbe}, стало num10 = {num10}"); // Numbe = 4, и num10 тоже 4

int level = 5;
int score = level++ + ++level; //читаем слева направо: 1)level ++ берет старое 5, потом level становится 6. 2)++level увеличивает 6 до 7, берет 7. 3) и складывает это: 5 + 7 = 12; => score = 12, level = 7
Console.WriteLine($"level++ + ++level = {score}, level = {level}");

Console.WriteLine("Задание 3");
Console.Write("Сумма покупки: ");
double s = double.Parse(Console.ReadLine());

Console.Write("карта клиента (1 - да, 0 - нет): ");
int k = int.Parse(Console.ReadLine());
bool card = (k == 1);

Console.Write("Товаров в чеке: ");
int t = int.Parse(Console.ReadLine());

bool s1 = s >= 3000;
bool t1 = t >= 3;
bool both = s1 && t1;
bool disc = both || card;

Console.WriteLine($"Сумма >= 3000: {s1}");
Console.WriteLine($"Товаров >= 3: {t1}");
Console.WriteLine($"Сумма и товары: {both}");
Console.WriteLine($"Карта: {card}");
Console.WriteLine($"Скидка: {disc}");

int r = 10 - 2 * 3 + 4 / 2;
Console.WriteLine($"10 - 2 * 3 + 4 / 2 = {r}");