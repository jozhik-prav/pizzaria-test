# Тестовое задание: Интернет-магазин-пиццерия

## Требования

1. Node.js v12.19.0
2. ASP.NET Core 3.1
3. Microsoft Visual Studio 2019
4. npm


## Установка и запуск проекта

1. ```mkdir test```
2. ```cd test```
3. ```git clone https://github.com/jozhik-prav/pizzaria-test.git```
4. ```cd .\pizzaria-test\Pizzeria\ClientApp\``` 
5. ```npm i```
6. Открыть в Visual Studio ```Pizzeria.sln``` и нажать ```F5```

## API

### Пиццы

Получить список пицц

```GET http://localhost:5000/api/pizzas HTTP/1.1```

Добавить новую пиццу

```http
POST http://localhost:5000/api/pizzas HTTP/1.1
content-type: application/json

{
    "name": "Маргарита",
    "ingredients": "Увеличенная порция моцареллы, томаты, итальянские травы, томатный соус",
    "price": 345,
    "picture": "" 
}
```
```// картинка в base64```

Добавить скидку пицце

```http
POST http://localhost:5000/api/pizzas/PIZZA_ID/setDiscountPrice HTTP/1.1 
content-type: application/json

 400
```
```// PIZZA_ID -идентификатор пиццы```

### Заказы

Получить список заказов

```GET http://localhost:5000/api/orders HTTP/1.1```

Отправить новый заказ

```
POST http://localhost:5000/api/orders HTTP/1.1
content-type: application/json

{
    "orderLines": [{                  
            pizzaId: pizza.id,
            count: count
        }, ...]
}
```
```// orderLines - массив строк заказа```