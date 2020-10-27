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
            <div :class="{ discount: isDiscount() }">
                <p class="card-price">{{ pizza.price }} ₽</p>
                <p v-if="isDiscount()" class="card-new-price">{{ pizza.discountPrice }} ₽</p>
            </div>
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

    isDiscount(): boolean {
        return this.pizza.discountPrice < this.pizza.price;
    }
}
</script>

<style lang="scss">
.card {
    width: 25%;
    padding: 20px 15px;
    margin-bottom: 40px;
    display: flex;
    flex-direction: column;
    border: 4px solid transparent;
    border-radius: 3px;

    @media screen and (max-width: 992px) {
        width: 33%;
    }
    @media screen and (max-width: 768px) {
        width: 50%;
    }
    @media screen and (max-width: 480px) {
        width: 100%;
    }

    &:hover {
        border-color: #fdbc2c;
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
    margin-bottom: 20px;
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

.discount {
    .card-price {
        color: #fff;
        text-decoration: line-through;
        font-size: 14px;
    }

    .card-new-price {
        color: #d94f2b;
        font-size: 24px;
        //margin-left: 10px;
    }
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
