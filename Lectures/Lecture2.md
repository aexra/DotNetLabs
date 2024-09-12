# Многомерные массивы

```cs
var a2 = new double[3, 4];
a[1, 2] = 7;
```

> [!NOTE]
> Такие массивы располагаются в памяти одним блоком.

# Функции

Общий вид:
<ReturnType> <FunctionName>(args) { <Body> }

> [!IMPORTANT]
> Приняты правила именования **PascalCase**

## Примеры записи:

Стрелочное выражение:
```cs
int Sum(int a, int b, int c) => a + b + c;
```

Значение по умолчанию:
```cs
int Sum(int a, int b = 1, int c = 0) => a + b + c;
```

## Вызов

- ```cs
  Sum(3, x);
  ```
- ```cs
  Sum(x);
  ```
- ```cs
  Sum(a: 3, b: x);
  Sum(b: 3; a: y + 4);
  ```
- ```cs
  Sum(4, c: 7, b: y + 4);
  ```
