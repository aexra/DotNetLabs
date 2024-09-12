### Платформы

3 основных платформы:
JAVA, .NET, JS и другие

### Компиляция

> [!IMPORTANT]
> Порядок компиляции .NET:<br>
> С# -> IL -> (JIT) -> Machine Code

IL ~~ Java Byte Code

Common Type System (CTM) by Microsoft for IL

IL extends IL

### Типы данных

Namespace style:<br>
```System.Collections.ArrayList```<br>
[namespace].[Name]
[FullName]

Не может быть двух типов данных с одинаковым FullName

> [!NOTE]
> ВСЕ типы доступны везде и всегда.<br>
> Для упрощения доступа используется директива ```using <namespace>;```

<table>
  <tr>
    <td>System.Byte</td>
    <td>byte</td>
  </tr>
  <tr>
    <td>System.Int16</td>
    <td>short</td>
  </tr>
  <tr>
    <td>System.Int32</td>
    <td>int</td>
  </tr>
  <tr>
    <td>System.Int64</td>
    <td>long</td>
  </tr>
  <tr>
    <td>System.Single</td>
    <td>float</td>
  </tr>
  <tr>
    <td>System.Double</td>
    <td>double</td>
  </tr>
  <tr>
    <td>System.Boolean</td>
    <td>bool</td>
  </tr>
  <tr>
    <td>System.Char</td>
    <td>char</td>
  </tr>
  <tr>
    <td>System.String</td>
    <td>string</td>
  </tr>
  <tr>
    <td>System.Object</td>
    <td>object</td>
  </tr>
</table>

ссылочные -> Object <- значимые

Ссылочные:
1. String
2. Классые
3. Массивы
4. Делегаты
5. Интерфейсы

Значимые:
1. Структуры
2. Базовые
3. Перечисления

#### Целые числа

##### Запись

27<br>
-5<br>
064<br>
0371<br>
0xA2F<br>
2_753_162<br>

##### Операции
+, -, *, /, %, &, |, ~, ^
