Задание

Утилита tree.

Выводит дерево каталогов и файлов (если указана опция -f).

Необходимо реализовать функцию `Build` класса `TreeBuilder`. 

Запускать тесты через `dotnet test` находясь в папке c заданием. После запуска вы должны увидеть такой результат:

```
$ dotnet test --nologo
Test run for C:\Workspace\Education\Rus\tree-utility\tree-utility\TreeUtility.Tests\bin\Debug\netcoreapp3.1\TreeUtility.Tests.dll(.NETCoreApp,Version=v3.1)
Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 2
     Passed: 2
 Total time: 1,5972 Seconds

```

```
$dotnet run -p .\TreeUtility\TreeUtility.csproj -- testdata -f
├───project
│       ├───file.txt (19b)
│       └───gopher.png (70372b)
├───static
│       ├───a_lorem
│       │       ├───dolor.txt (empty)
│       │       ├───gopher.png (70372b)
│       │       └───ipsum
│       │               └───gopher.png (70372b)
│       ├───css
│       │       └───body.css (28b)
│       ├───empty.txt (empty)
│       ├───html
│       │       └───index.html (57b)
│       ├───js
│       │       └───site.js (10b)
│       └───z_lorem
│               ├───dolor.txt (empty)
│               ├───gopher.png (70372b)
│               └───ipsum
│                       └───gopher.png (70372b)
├───zline
│       ├───empty.txt (empty)
│       └───lorem
│               ├───dolor.txt (empty)
│               ├───gopher.png (70372b)
│               └───ipsum
│                       └───gopher.png (70372b)
└───zzfile.txt (empty)

$dotnet run -p .\TreeUtility\TreeUtility.csproj -- testdata
├───project
├───static
│       ├───a_lorem
│       │       └───ipsum
│       ├───css
│       ├───html
│       ├───js
│       └───z_lorem
│               └───ipsum
└───zline
        └───lorem
                └───ipsum
```

Замечания:
* Перенос строки - windows-style ( \r\n )
* Отступы - символ графики + символ табуляции ( \t )
* Для расчета символа графики в отступах подумайте про последний элемент и префикс предыдущих уровней. Там довольно простое условие. Хорошо помогает проговорить вслух то что вы видите на экране.
* Рекурсивный алгоритм проще всего. Но можно реализовать и не-рекурсивно
* Вы можете реализовать любые нужные вам функции, вы не ограничены в единственной Build. Если вам нужно больше аргументов - создайте другую функцию и вызывайте её рекурсивно. Build в этом случае может быть только входной точкой.
* Символы графики лучше копируйте не из текста задания ( который вы читаете сейчас ), а из исходного кода теста ( TreeBuilderTest.cs )
* Результаты ( список папок-файлов ) должны быть отсортированы по алфавиту. Т.е. у вас должен быть код который отсортирует уровень (можно использовать стандартные инструменты)
* У вас может быть соблазн использовать статические переменные, но вариант с рекурсией проще получается без них, а в не-рекурсивном варианте они вообще не нужны
* сигнатуру функции Build ( количество параметров ) менять нельзя

