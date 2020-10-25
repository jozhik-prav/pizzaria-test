export interface Pizza {
    id: string,
    name: string,
    ingredients: string,
    price: number,
    picture: string
}

export interface OrderLine {
    pizza: Pizza,
    count: number
}