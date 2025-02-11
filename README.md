<a id="anchor"></a>
# Partial Properties in C13 and .NET9
## Частичные свойства в C# 13
[<img target="_blank" src="Partial Properties in CSharp13 1.png" width="600"/>](https://vkvideo.ru/video614312645_456239033)

**Частичные свойства — это новая функция**, представленная в версии C# 13, которая приносит дополнительную гибкость и удобство для разработчиков. В этой статье мы рассмотрим, как понять и внедрить частичные свойства с использованием Visual Studio.</br>
### Введение в частичные свойства
Частичные свойства позволяют разделять определение свойства на несколько файлов или внутри одного файла, предоставляя более чистый и модульный способ управления вашим кодом. Эта функция особенно полезна для больших проектов, где поддержание одного файла для класса может стать громоздким.
### Настройка проектов
Для демонстрации частичных свойств мы будем использовать два проекта:</br>
  1.	Проект на .NET 8 (C# 12): Этот проект не поддерживает частичные свойства и будет служить базовым.</br>
  2.	Проект на .NET 9 (C# 13): Этот проект будет использовать новую функцию частичных свойств.</br>
## Проект на .NET 8
В проекте на .NET 8 у нас есть файл Program.cs с частичным классом Customer. Вот разбор кода:
```csharp
  public partial class Customer
  {
      private string name;
      public string GetName()
      {
          return name;
      }
      public void SetName(string name)
      {
        this.name = name;
      }
  }
```
## Объяснение
  •	**Частное пол**е: Поле name является частным и доступно только через методы getter и setter.
  •	**Методы getter и setter**: Методы GetName и SetName используются для доступа и изменения поля name.
### Использование
```csharp
  Customer customer = new Customer();
  customer.SetName("John Doe");
  Console.WriteLine(customer.GetName());
```
### Ограничения
Поскольку частичные свойства недоступны в C# 12, мы должны использовать методы getter и setter. Попытка использовать ключевое слово partial со свойствами приводит к ошибке компиляции.
### Проект на .NET 9
В проекте на .NET 9 мы можем использовать частичные свойства для упрощения нашего кода. Давайте посмотрим как:</br>
**Шаг 1: Определение частичного свойства**
```csharp
  public partial class Customer
  {
      public partial string Name { get; set; }
  }
```

**Шаг 2: Реализация частичного свойства</br>**
В другой части частичного класса предоставляется реализация свойства:
```csharp
  public partial class Customer
  {
      private string _name;
  
      public string Name
      {
          get => _name;
          set => _name = value;
      }
  }
```

### Использование
```csharp
  Customer customer = new Customer();
  customer.Name = "John Doe";
  Console.WriteLine(customer.Name);
```
### Преимущества
>  •	Чистый код: Используя частичные свойства, мы устраняем необходимость в отдельных методах getter и setter.</br>
>  •	Модульность: Определение и реализация свойства могут быть разделены на разные части частичного класса, что улучшает организацию кода.
### Заключение
>> Частичные свойства в C# 13 предлагают более рациональный подход к управлению свойствами классов, сокращая количество шаблонного кода и улучшая поддерживаемость кода. Переходя на .NET 9 и используя эту функцию, разработчики могут писать более чистый и модульный код.</br>
>> В этой статье мы продемонстрировали настройку и использование частичных свойств, выделив различия между C# 12 и C# 13. Примите эту новую функцию, чтобы улучшить свои практики кодирования и структуру проекта.</br>
<a href="https://github.com/DeNaN20250203" target="_blank"><img src="GitHubDeJra.png" alt="Image" width="300" /></a>
[Верх](#anchor)
