<template>
    <div class="card">
        <div class="card-image">
            <img :src="pizza.picture" alt="" />
        </div>
        <div class="card-content">
            <h5 class="card-title">{{ pizza.name }}</h5>
            <p class="card-text">{{ pizza.ingredients }}</p>
        </div>
        <div class="card-footer">
            <p class="card-price">{{ pizza.price }} ₽</p>
            <button class="btn btn-primary" @click="addToBasket()">Добавить</button>
        </div>
    </div>
</template>

<script lang="ts">
import { Pizza } from '@/Types';
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class MenuItem extends Vue {
    @Prop() private pizza!: Pizza;

    addToBasket() {
        this.$store.commit('addPizza', {
            pizza: this.pizza,
            count: 1
        });
    }
}
</script>

<style lang="scss">
.card {
    width: 25%;
    padding: 0 15px;
    margin-bottom: 10px;
    display: flex;
    flex-direction: column;
    @media screen and (max-width: 992px) {
        width: 33%;
    }
    @media screen and (max-width: 768px) {
        width: 50%;
    }
    @media screen and (max-width: 480px) {
        width: 100%;
    }
}

.card-image {
    img {
        display: block;
        margin: 0 auto;
        max-width: 100%;
        height: auto;
    }
}

.card-content {
    margin-bottom: 10px;
    flex-grow: 1;
}

.card-title {
    color: #fdbc2c;
    font-size: 24px;
    padding: 10px 0;
}

.card-text {
    font-size: 17px;
}

.card-footer {
    display: flex;
    justify-content: space-between;
    align-items: center;
    .btn {
        margin-bottom: 0;
    }
}
.card-price {
    color: #d94f2b;
    font-size: 24px;
}

.card-btn {
    background-color: #fdbc2c;
    padding: 4px 20px;
    border: 1px solid #fdbc2c;
    color: #000;
    font-size: 14px;
    font-weight: 700;
}
</style>
