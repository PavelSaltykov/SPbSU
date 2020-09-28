# SPbU Homework and Tests

| [Semester №1](#semester-1) | [Semester №2](#semester-2) |
| :-: | :-: |
| [Homework №1](#homework-1) | [Homework №1](#homework-1-1) |
| [Homework №2](#homework-2) | [Homework №2](#homework-2-1) |
| [Homework №3](#homework-3) | [Homework №3](#homework-3-1) |
| [Homework №4](#homework-4) | [Homework №4](#homework-4-1) |
| [Homework №6](#homework-6) | [Homework №6](#homework-6-1) |
| [Homework №7](#homework-7) | [Homework №7](#homework-7-1) |
| [Homework №8](#homework-8) |                              |
| [Homework №9](#homework-9) | [Homework №9](#homework-9-1) |
| [Homework №10](#homework-10) | [Homework №10](#homework-10-1) |
| [Homework №11](#homework-11) |
| [Homework №12](#homework-12) | 
| [Homework №13](#homework-13) | 

## Semester №1
#### Homework №1
1. Написать программу, считающую значение формулы `x^4 + x^3 + x^2 + x + 1` за два умножения. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.1)

2. Написать программу нахождения неполного частного от деления `a` на `b` (целые числа), используя только операции сложения, вычитания и умножения. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.2)

3. Дан массив целых чисел `x[1] ... x[m + n]`, рассматриваемый как соединение двух его отрезков: начала `x[1] ... x[m]` длины `m` и конца `x[m + 1] ... x[m + n]` длины `n`. Не используя дополнительных массивов, переставить начало и конец (обращением двух частей массива, а потом его самого). [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.3)

4. Посчитать число "счастливых билетов" (билет считается "счастливым", если сумма первых трёх цифр его номера равна сумме трёх последних), подсчётом числа билетов с заданной суммой трёх цифр. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.4)

5. Написать программу проверки баланса скобок в исходной строке (т.е. число открывающих скобок равно числу закрывающих и выполняется правило вложенности скобок).
[Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.5)

6. Заданы две строки: `S` и `S1`. Найти количество вхождений `S1` в `S` как подстроки. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.6)

7. Написать программу, печатающую все простые числа, не превосходящие заданного числа. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.7)

8. Написать программу, считающую количество нулевых элементов в массиве. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW1/1.8)

#### Homework №2
1. Реализовать вычисление чисел Фибоначчи рекурсивно (и убедиться, что при `n ~ 37` уже заметно медленно), реализовать итеративно, почувствовать разницу. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW2/2.1)

2. Реализовать возведение в степень — в лоб (за линейное время) и за `О(log n)`. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW2/2.2)

3. Написать сортировки пузырьком и подсчётом. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW2/2.3)

4. Написать программу, которая заполняет массив случайными значениями, потом преобразует его без использования дополнительных массивов так, что в начале массива будут элементы, меньшие первого, а в конце — большие либо равные первому. Программа должна работать за линейное время. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW2/2.4)

#### Homework №3
1. Реализовать qsort, который для сортировки кусков массива размером меньше 10 использует сортировку вставкой. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW3.Sorting/3.1)

2. Получить с клавиатуры 2 числа, `n` и `k`, сгенерировать случайно массив из `n` чисел, сгенерировать `k` случайных целых чисел, для каждого из них проверить, содержится ли оно в массиве. Надо придумать алгоритм с временной сложностью `O(n log n + k log n)`, или лучший. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW3.Sorting/3.2)

3. Найти наиболее часто встречающийся элемент в массиве быстрее, чем за `O(n^2)`. Если таких элементов несколько, надо вывести любой из них. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW3.Sorting/3.3)

#### Homework №4
1. Ввести два числа, перевести в двоичное представление в дополнительном коде и напечатать, сложить в столбик в двоичном представлении, вывести сумму, перевести в десятичное, вывести сумму в десятичном виде. Все сообщения писать по-русски (рекомендуется использовать функцию `setlocale`, чтобы сообщения выводились по-русски и под Windows тоже). [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW4/4.1)

2. Переделать задачу 3 из прошлого задания так, чтобы сортировка была в отдельном модуле и читала входные данные из файла. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW4/4.2)

3. Написать программу - телефонный справочник. Она должна уметь хранить имена и номера телефонов, в интерактивном режиме осуществлять следующие операции:\
 `0 - выйти`\
 `1 - добавить запись (имя и телефон)`\
 `2 - распечатать все имеющиеся записи`\
 `3 - найти телефон по имени`\
 `4 - найти имя по телефону`\
 `5 - сохранить текущие данные в файл`\
При запуске программа должна читать данные из файла (того самого, в который сохраняет данные), если файла нет - начинать с пустой базы номеров. Размер базы ограничен сотней записей. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW4/4.3)

#### Homework №6
1. Написать программу для вычисления арифметического выражения в постфиксной форме. С клавиатуры вводится последовательность цифр (для простоты) и операций `+, -, *, /`, представляющая выражение в постфиксной форме, должен выводиться результат вычисления. Например, на тесте `9 6 - 1 2 + *` должно получиться `9`. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW6.Stack/6.1)

2. Написать программу проверки баланса скобок в строке, скобки могут быть трёх видов: `(), [], {}`. Скобочная последовательность вида `({)}` считается некорректной, `({})` - корректной. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW6.Stack/6.2)

3. Написать программу, преобразующую выражение из инфиксной формы в постфиксную. В выражении могут быть знаки `+, -, *, /`, скобки и цифры. Пример: `(1 + 1) * 2` должно преобразовываться в `1 1 + 2 *`. Алгоритм перевода предлагается найти самостоятельно (алгоритм "сортировочной станции" Э. Дейкстры). [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW6.Stack/6.3)

   Задачи 1, 2 и 3 решаются с помощью стека - его надо реализовать единожды в отдельном модуле, и использовать во всех этих задачах. Комментарии ко всем функциям из заголовочного файла обязательны.

#### Homework №7
1. Написать программу, которая в диалоговом режиме позволяет осуществлять следующие операции:\
 `0 – выйти`\
 `1 – добавить значение в сортированный список`\
 `2 – удалить значение из списка`\
 `3 – распечатать список`\
Все операции должны сохранять сортированность. Начинаем с пустого списка. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW7.Lists/7.1)

2. "Считалочка" – отряд из 41-го сикария, защищавший галилейскую крепость Массада, не пожелал сдаваться в плен блокировавшим его превосходящим силам римлян. Сикарии стали в круг и договорились, что каждые два воина будут убивать третьего, пока не погибнут все. Самоубийство – тяжкий грех, но тот, кто в конце концов останется последним, должен будет его совершить. Иосиф Флавий, командовавший этим отрядом, якобы быстро рассчитал, где нужно стать ему и его другу, чтобы остаться последними, но не для того, чтобы убить друг друга, а чтобы сдать крепость римлянам. В нашем случае участвует n воинов и убивают каждого `m-го`. Требуется определить номер `k` начальной позиции воина, который должен будет остаться последним. Считать с помощью циклического списка. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW7.Lists/7.2)

3. Реализовать сортировку слиянием. Во входном файле последовательность записей "имя - номер телефона". Программа должна отсортировать эти записи либо по имени, либо по номеру телефона, в зависимости от выбора пользователя, и вывести результат на экран. Количество записей заранее неизвестно, так что надо реализовывать списками на указателях. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW7.Lists/7.3)

#### Homework №8
1. Реализовать АТД "словарь" на основе двоичного дерева поиска, хранящий ключи типа `int` и связанные с ними значения типа `char *`. Должны поддерживаться следующие операции:
   - Добавить значение по заданному ключу в словарь. Если такой ключ уже есть, значение заменяется на новое.
   - Получить значение по заданному ключу из словаря. Если такого ключа нет, возвращается `nullptr`.
   - Проверить наличие заданного ключа в словаре.
   - Удалить заданный ключ и связанное с ним значение из словаря. Если такого ключа нет, функция ничего не делает.

   Программа должна работать в интерактивном режиме, то есть пользователю должно предоставляться меню, позволяющее выполнить эти операции [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW8.Tree/8.1)

2. По дереву разбора арифметического выражения вычислить его значение. Дерево разбора хранится в файле в виде (<операция> <операнд1> <операнд2>), где <операнд1> и <операнд2> сами могут быть деревьями, либо числами. Например, выражение `(1 + 1) * 2` представляется в виде `(* (+ 1 1) 2)`. Должны поддерживаться операции `+, -, *, /` и целые числа в качестве аргументов. Требуется построить дерево в явном виде, распечатать его (не обязательно так же, как в файле), и посчитать значение выражения обходом дерева. Может быть полезна функция `ungetc` (если не '(', возвращаем символ в поток и читаем число `fscanf`-ом). Можно считать, что входной файл корректен. Пример - по входному файлу `(* (+ 1 1) 2)` может печататься `( * ( + 1 1 ) 2 )` и выводиться `4`. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW8.Tree/8.2)

#### Homework №9
1. Реализовать словарь с ключами и значениями типа `char *` на основе АВЛ-дерева. Должны поддерживаться следующие операции.
   - Добавить значение по заданному ключу в словарь. Если такой ключ уже есть, значение заменяется на новое.
   - Получить значение по заданному ключу из словаря. Если такого ключа нет, возвращается `nullptr`.
   - Проверить наличие заданного ключа.
   - Удалить заданный ключ и связанное с ним значение из словаря. Если такого ключа нет, функция ничего не делает.
   
   Программа должна работать в интерактивном режиме, то есть пользователю должно предоставляться меню, позволяющее выполнить эти операции. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW9.AVLTree/9.1)
   
#### Homework №10
1. Посчитать частоты встречаемости слов в тексте с помощью хеш-таблицы. На входе файл с текстом, вывести на консоль все слова, встречающиеся в этом тексте с количеством раз, которое встречается каждое слово. Словом считается последовательность символов, разделённая пробелами, разные словоформы считаются разными словами. Хеш-таблицу реализовать в отдельном модуле, использующем модуль "Список". Подсчитать и вывести также коэффициент заполнения хеш-таблицы, максимальную и среднюю длину списка в сегменте таблицы. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW10.HashTable/10.1)

#### Homework №11
1. Есть множество городов и дороги, связывающие эти города. Для каждой дороги задана её длина. Задача – распределить города между государствами по такому алгоритму: задаются `k` столиц каждого государства, далее по очереди каждому государству добавляется ближайший незанятый город, непосредственно связанный дорогой с каким-либо городом, уже принадлежащим государству (столицей или каким-либо городом, добавленным на одном из предыдущих шагов). Процесс продолжается до тех пор, пока все города не будут распределены. Граф дорог связный. Во входном файле: `n` – число городов и `m` – число дорог. Далее следуют сами дороги в формате: `i j len`, `i` и `j` – номера городов, `len` – длина дороги. Далее задано число `k` – число столиц, далее – `k` чисел – номера столиц. Надо вывести на консоль номера государств и списки городов, принадлежащих государствам.  [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW11.Graph/11.1)

#### Homework №12
1. Реализовать поиск подстроки любым из рассмотренных алгоритмов. Из файла читается текст, с консоли - строка, программа должна выводить на консоль позицию первого вхождения введённой строки в файле. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW12/12.1)

2. По данному неориентированному графу построить минимальное остовное дерево одним из рассмотренных алгоритмов. В файле задаётся матрица смежности, программа должна вывести на консоль минимальное остовное дерево в каком-либо представлении. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW12/12.2)

#### Homework №13
1. Реализовать с помощью `switch` по состоянию лексический анализатор, проверяющий, является ли введённая последовательность символов вещественным числом (вещественное число задаётся регулярным выражением `digit+ (. digit+)? (E(+ | -)? digit+)?`, где `digit - [0..9]`). [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW13.Automaton/13.1)

2. С помощью ДКА с явной таблицей состояний, заданной в файле, вывести на консоль все комментарии С++ вида `/* комментарий */` из входного файла (вместе с символами `/*` `*/`). [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester1/Homeworks/HW13.Automaton/13.2)

- - -

## Semester №2
#### Homework №1
1. Посчитать факториал [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW1/Task1)

2. Посчитать числа Фибоначчи  [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW1/Task2)

3. Отсортировать массив какой-либо из сортировок [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW1/Task3)

4. Дан массив размерностью `N x N`, `N` - нечетное число. Вывести элементы массива при обходе его по спирали, начиная с центра [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW1/Task4)

5. Отсортировать столбцы матрицы по первым элементам [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW1/Task5)

#### Homework №2
1. Написать связный список в виде класса. От списка хочется:
   - Добавлять/удалять элемент по произвольной позиции, задаваемой целым числом
   - Узнавать размер, проверять на пустоту
   - Получать или устанавливать значение элемента по позиции, задаваемой целым числом/
   
   [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW2/Task1)
   
2. Написать хеш-таблицу в виде класса с использованием класса-списка из первой задачи. Должно быть можно добавлять значение в хеш-таблицу, удалять и проверять на принадлежность [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW2/Task2)

3. Реализовать стековый калькулятор (класс, реализующий выполнение операций `+, -, *, /` над арифметическим выражением в виде строки в постфиксной записи). Строка уже дана в обратной польской записи (например, `1 2 3 + *`). Стек реализовать двумя способами (например, массивом или списком) в двух разных классах на основе одного интерфейса. Стековый калькулятор должен знать только про интерфейс стека. В `Main` надо спросить у пользователя, какой из вариантов стека он хочет, в зависимости от выбора создаётся объект одной из двух реализаций и передаётся калькулятору. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW2/Task3)

#### Homework №3
1. Написать юнит-тесты к задаче 3 из предыдущего задания [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW2/Task3)

2. Модифицировать хеш-таблицу из задачи 2 предыдущей работы так, чтобы хеш-функцию можно было менять в зависимости от выбора пользователя, причём хеш-функцию должно быть можно передавать из использующего хеш-таблицу кода в виде объекта некоторого класса, реализующего некоторый интерфейс. Хеш-функцию должно быть можно менять во время работы. Юнит-тесты и коментарии в формате XML Documentation обязательны. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW3/Task2)

#### Homework №4
1. Решить задачу о вычислении выражения по дереву разбора из прошлого семестра. Реализовать иерархию классов, описывающих дерево разбора, используя их, реализовать класс, вычисляющий значение выражения по дереву. Классы, представляющие операнды и операторы, должны сами уметь себя вычислять и печатать.

   Исходное условие:

   >По дереву разбора арифметического выражения вычислить его значение. Дерево разбора хранится в файле в виде (<операция> <операнд1> <операнд2>), где <операнд1> и <операнд2> сами могут быть деревьями, либо числами. Например, выражение `(1 + 1) * 2` представляется в виде `(* (+ 1 1) 2)`. Должны поддерживаться операции `+, -, *, /` и целые числа в качестве аргументов. Требуется построить дерево в явном виде, распечатать его (не обязательно так же, как в файле), и посчитать значение выражения обходом дерева. Может быть полезна функция ungetc (если не '(', возвращаем символ в поток и читаем число fscanf-ом). Можно считать, что входной файл корректен. Пример - по входному файлу `(* (+ 1 1) 2)` может печататься `( * ( + 1 1 ) 2 )` и выводиться 4.
    
   [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW4/Task1)

2. Унаследовавшись от класса список, реализовать класс `UniqueList`, который не содержит повторяющихся значений. Реализовать классы исключений, которые генерируются при попытке добавления в такой список уже существующего или при попытке удаления несуществующего элемента. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW4/Task2)

#### Homework №6
1. Реализовать функции `Map`, `Filter` и `Fold`:
   - `Map` принимает список и функцию, преобразующую элемент списка. Возвращаться должен список, полученный применением переданной функции к каждому элементу переданного списка. Например, `Map(new List<int>() {1, 2, 3}, x => x * 2)` должен возвращать список `[2; 4; 6]`.
   - `Filter` принимает список и функцию, возвращающую булевое значение по элементу списка. Возвращаться должен список, составленный из тех элементов переданного списка, для которых переданная функция вернула `true`.
   - `Fold` принимает список, начальное значение и функцию, которая берёт текущее накопленное значение и текущий элемент списка, и возвращает следующее накопленное значение. Сама `Fold` возвращает накопленное значение, получившееся после всего прохода списка. Например, `Fold(new List<int>() {1, 2, 3}, 1, (acc, elem) => acc * elem)` работала бы так: сначала в `acc` клался бы 1, потом умножался бы на 1, потом результат (1) умножался бы на 2, потом результат (2) умножался бы на 3, потом результат (6) возвращался бы в качестве ответа.
   Если умеете генерики, подумайте, как сделать тип функций наиболее общим. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW6/Task1)

2. На базе класса, генерирующего события по нажатию на клавиши управления курсором (EventLoop с пары), реализовать консольное приложение, позволяющее управлять персонажем, перемещающимся по карте. Карта состоит из свободного пространства и стен, и должна грузиться из файла. Приложение должно отображать карту и персонажа (символом `@`) в окне консоли, и позволять персонажу перемещаться по карте, реагируя на клавиши управления курсором. Будут полезны свойства `Console.CursorLeft` и `Console.CursorTop`. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW6/Task2)

#### Homework №7
1. Написать калькулятор с пользовательским интерфейсом (по примеру стандартного виндового калькулятора) [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW7.WinForms/Task1)

2. Сделать часы (приложение, показывающее текущее системное время) со стрелками (часовой, минутной и секундной). Здесь юнит-тесты можно не писать. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW7.WinForms/Task2)

#### Homework №9
1. Создать генерик-класс, реализующий АТД "Множество". Множество должно реализовывать интерфейс `System.Collections.Generic.ISet`. Ожидается асимптотическая трудоёмкость основных операций не хуже в среднем логарифмической (то есть несбалансированное двоичное дерево тоже пойдёт). Проверить в тестах, что по множеству можно ходить `foreach`. [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW9.Set/Task1)

#### Homework №10
1. Нарисовать на UML диаграмму классов для игры "реверси", с несколькими видами "ботов", которые могли бы играть вместо человека. Диаграмма должна быть довольно подробным проектом системы. Реализовывать этот проект не нужно. Желательно пользоваться средствами визуального моделирования наподобие Visual Paradigm (https://www.visual-paradigm.com/download/community.jsp), присылать скриншоты с диаграммой и исходники (файлы .vpp в случае Visual Paradigm) [Solution](https://github.com/PavelSaltykov/Course1/tree/master/Semester2/Homeworks/HW10.UML)
