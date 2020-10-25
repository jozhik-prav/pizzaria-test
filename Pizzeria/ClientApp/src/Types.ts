export interface Pizza {
    name: string,
    ingredients: string,
    price: number,
    picture: string
}

export interface OrderLine {
    pizza: Pizza,
    count: number
}