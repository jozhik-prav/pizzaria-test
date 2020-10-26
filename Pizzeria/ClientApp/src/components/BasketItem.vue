<template>
    <article class="item">
        <img class="item-img" :src="orderLine.pizza.picture" alt="" />
        <main class="item-content">
            <h5>{{ orderLine.pizza.name }}</h5>
            <p>{{ orderLine.pizza.ingredients }}</p>
        </main>
        <div class="item-control">
            <button class="control-btn" @click="decrement">-</button>
            <span> {{ orderLine.count }} </span>
            <button class="control-btn" @click="increment">+</button>
        </div>
        <div class="item-price" :class="{ discount: isDiscount() }">
            <p class="price">{{ orderLine.pizza.price }} ₽</p>
            <p class="new-price" v-if="isDiscount()">{{ orderLine.pizza.discountPrice }} ₽</p>
        </div>
        <a class="item-delete" @click="remove"><img src="../assets/delete.svg" alt=""/></a>
    </article>
</template>

<script lang="ts">
import { OrderLine } from '@/Types';
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class BasketItem extends Vue {
    @Prop() private orderLine!: OrderLine;

    increment() {
        this.$store.dispatch('incrementCountPizza', this.orderLine.pizza.id);
    }

    decrement() {
        this.$store.dispatch('decrementCountPizza', this.orderLine.pizza.id);
    }

    remove() {
        this.$store.dispatch('deleteOrderLine', this.orderLine.pizza.id);
    }

    isDiscount(): boolean {
        return this.orderLine.pizza.discountPrice < this.orderLine.pizza.price;
    }
}
</script>

<style lang="scss" scoped>
.item {
    display: flex;
    align-items: center;
    box-shadow: 0px 2px 0px 0px #010202;
    border-bottom: 1px solid #383838;
    padding: 10px 0;
    @media screen and (max-width: 480px) {
        flex-wrap: wrap;
        justify-content: center;
    }
}

.item-img {
    width: 100px;
    flex: 0 0 auto;
    margin-right: 12px;
}

.item-content {
    display: flex;
    flex: 1 1 auto;
    flex-flow: column;
    justify-content: center;
    h5 {
        color: #fdbc2c;
        font-size: 24px;
    }
    @media screen and (max-width: 480px) {
        flex: 1 1 70%;
    }
}

.item-control {
    flex: 0 0 auto;
    display: flex;
    align-items: center;
    border: 1px solid #fdbc2c;
    border-radius: 5px;
    .control-btn {
        background: transparent;
        color: #fff;
        padding: 0 20px;
        border: none;
        outline: none;
        font-size: 24px;
        cursor: pointer;

        &:hover {
            color: #d94f2b;
        }
    }
}

.item-price {
    flex: 0 0 auto;
    display: flex;
    flex-flow: column;
    justify-content: center;
    padding: 0 10px;
    margin: 0 12px;
    text-align: center;
    .price {
        color: #d94f2b;
        font-size: 24px;
    }
}

.discount {
    .price {
        color: #fff;
        text-decoration: line-through;
        font-size: 14px;
        margin-top: -17px;
    }

    .new-price {
        color: #d94f2b;
        font-size: 24px;
    }
}

.item-delete {
    display: flex;
    flex-flow: column;
    justify-content: center;
    img {
        width: 20px;
    }
}
</style>
