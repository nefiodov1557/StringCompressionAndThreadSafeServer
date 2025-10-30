# 🧩 StringCompressionAndThreadSafeServer

## 📖 Описание проекта

Проект состоит из двух независимых задач и тестов, реализованных на C# (.NET 8):

1. **Task 1 — String Compression**  
   Алгоритм для сжатия строк по принципу Run-Length Encoding.  
Реализованы методы `Compress()` и `Decompress()` с проверками и тестами.

2. **Task 2 — Thread Safe Server**  
Потокобезопасный сервер, корректно обрабатывающий параллельное увеличение счётчика.  
Используется `lock` для синхронизации доступа к общим данным.

---

## ⚙️ Технологии

- **C# / .NET 8**
- **Visual Studio 2022**
- **MSTest Framework**
- **Parallel.For / Multithreading**
- **Lock synchronization**

---

## 🚀 Запуск проекта

1. Открыть решение `StringCompressionAndThreadSafeServer.sln` в **Visual Studio 2022**  
2. Установить конфигурацию **Debug / Any CPU**
3. Выбрать проект **StringCompressionAndThreadSafeServer** как запускаемый  
4. Нажать **F5** (или “Запуск без отладки”)

---

## 🧪 Запуск тестов

1. Выбрать проект **Task1_Test** как запускаемый  
2. Нажать **F5** (или “Запуск без отладки”)
3. Выбрать проект **Task2_Test** как запускаемый  
4. Нажать **F5** (или “Запуск без отладки”)
---

## 📄 Автор

**Нефедов Дмитрий Алексеевич**  
💻 *Developer C# / .NET, WPF, MySQL*  
📧 [nefedovdima03@mail.ru](mailto:nefedovdima03@mail.ru)

---

## 🏁 Пример вывода программы

Задача 1
Исходная строка: aaabbcccdde
Сжатая строка: a3b2c3d2e1
Разжатая строка: aaabbcccdde

Задача 2
Ожидаемое значение: 10000
Фактическое значение: 10000
