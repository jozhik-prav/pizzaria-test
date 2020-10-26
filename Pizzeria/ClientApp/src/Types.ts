export interface Pizza {
    id: string,
    name: string,
    ingredients: string,
    price: number,
    discountPrice: number,
    picture: string
}

export interface OrderLine {
    pizza: Pizza,
    count: number
}