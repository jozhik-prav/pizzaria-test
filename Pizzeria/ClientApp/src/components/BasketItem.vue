<template>
    <article class="item">
        <img class="item-img" :src="orderLine.pizza.picture" alt="" />
        <main class="item-content">
            <h5>{{ orderLine.pizza.name }}</h5>
            <p>{{ orderLine.pizza.ingredients }}</p>
        </main>
        <div class="item-control">
            <button class="control-btn">-</button>
            <span> {{ orderLine.count }} </span>
            <button class="control-btn">+</button>
        </div>
        <div class="item-price">{{ orderLine.pizza.price }} ₽</div>
        <div class="item-delete"><img src="../assets/delete.svg" alt="" /></div>
    </article>
</template>

<script lang="ts">
import { OrderLine } from '@/Types';
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class BasketItem extends Vue {
    @Prop() private orderLine!: OrderLine;
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
    color: #d94f2b;
    font-size: 24px;
    flex: 0 0 auto;
    display: flex;
    flex-flow: column;
    justify-content: center;
    padding: 0 10px;
    margin: 0 12px;
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
