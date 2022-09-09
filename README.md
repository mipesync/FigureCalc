# Задание 1.
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в compile-time
* Проверку на то, является ли треугольник прямоугольным

Библиотека: [ссылка](https://github.com/mipesync/FigureCalc/tree/master/FigureCalc)

Юнит тексты: [ссылка](https://github.com/mipesync/FigureCalc/tree/master/FigureCalcTests)
# Задание 2.
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```sql
SELECT Products.name, Categories.name FROM Products
LEFT JOIN ProdCat ON Products.id = productId
LEFT JOIN Categories ON ProdCat.categoryId = Categories.id
```
Получаем такой вывод:

![image](https://user-images.githubusercontent.com/73836153/189400110-fea8d12e-ab1f-4555-adda-7dda5759e369.png)
