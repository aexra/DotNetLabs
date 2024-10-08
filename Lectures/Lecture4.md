```cs
F MakeAdder(double delta)
{
  return x => {
    return x + delta;
  };
}
/////////////////////////////////
ВРЕМЯ ЖИЗНИ delta ЗАКОНЧИЛОСЬ ТУТ
/////////////////////////////////

var inc = MakeAdder(1);
var dec3 = MakeAdder(-3);

inc(4); // 5
dec3(4); // 1
```

Когда в теле функции (чаще всего это лямбды - анонимные функции) встречаются какие-либо переменные, время жизни которых меньше чем время жизни рассматриваемой функции, то такая функция **захватывает (*замыкает*)** эти переменные с собой эти переменные и уносит их с собой в своем специальном контексте "**Контекст вызова**".

Например:<br>
Переменная ```inc``` имеет ссылки на *код делегата* и ссылки на *контекст*<br>
Переменная ```dec3``` имеет ссылку на тот же *код делегата* и ссылки на свой *контекст*<br>

```cs
? MakeTab(double x0, double x1, double step)
{
  return f => tab(x0, x1, step, f);
}

var t0_1 = MakeTab(0, 1, 0.01);

t0_1(Math.Sin);
t0_1(x => 2 * x + 1);
```

### Особенности делегатов, которых нет в других функциональных языках
#### Мультиделегат

```cs
void LogConsole(object o) => Console.WriteLine(o);
void LogFile(object o) => File.AppendText("a.log", o.ToString());

// МУЛЬТИДЕЛЕГАТ - строка запишется и в консоль и в файл
var l = LogConsole;
l += LogFile;

// МУЛЬТИДЕЛЕГАТ - НЕ множество
l += LogConsole; // Будет двойной вызов

// Можно убирать (по 1)
l -= LogConsole;

// Если убрать всё, то l = null
l -= LogConsole;
l -= LogFile;

l == null; // true
```

> [!NOTE]
> Среда .NET не специфицирует порядок вызова

# Классы

```cs
[<модификаторы>] class <имя>[:<предок>[,<список интерфейсов>]]
{
  <члены класса>
}
```

### Модификаторы

#### Модификаторы сборки
1. public
2. protected
3. private
4. internal
У любого члена класса по умолчанию видимость ```private```.

#### Модификаторы другие
1. static
2. abstract
3. sealed - запрещает наследование
4. partial - разделение описание, необходимо одно и то же пространство имен

### Предок
Любой класс, если он не sealed. Если предок не указан, то считается System.Object.

### Спикок интерфейсов
Список реализуемых интерфейсов

### Члены класса
1. Поля ```cs [<модификатор>] <тип> <имя> [= <инициализатор>] ```
2. Методы

#### Модификаторы
1. static
2. readonly
3. const - не занимае памяти в объекте

> [!IMPORTANT]
> По правилам хорошего тона все поля ```private```
