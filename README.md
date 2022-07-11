# Пояснения
## Задача на фигуры
В данном репозитории реализована библиотека классов CountingAreas, класс для юнит тестов TestCalculatorAreas
Подсчет площади происходит через вызов метода Area(), возможность подсчета площади независимо от фигуры, реализована через переопределение
метода Area() в классах наследниках Figure
Метод проверки "прямоугольности" реализован в классе Triungulum
## Задача на SQL
Решение находиться в этом же репозитории, с адресом  
В условии описана ситуация отношения многие ко многим, в таких ситуциях должно существать три таблицы, товары, категории и таблица связи товаров и категорий 
+ таблица товаров - Prodacts, и в ней существуют столбцы id и info
+ таблица категорий - KindOfProdacts с одним из столбцов: id
+ таблица отношений - Prodacts_KindOfProdacts
Тогда код решения будет выглядеть:
  ```SELECT
	Prodacts.id,
	Prodacts.info,
	Prodacts_KindOfProdacts.id_Prodacts,
	Prodacts_KindOfProdacts.id_KindOfProdacts 
  FROM Prodacts
  LEFT JOIN Prodacts_KindOfProdacts ON Prodacts.id = Prodacts_KindOfProdacts.id_Prodacts;
  ```
