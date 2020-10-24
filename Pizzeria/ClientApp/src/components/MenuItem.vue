<template>
    <div class="card">
        <div class="card-image">
            <img :src="picture" alt="">
        </div>
        <div class="card-content">
            <h5 class="card-title">{{ name }}</h5>
            <p class="card-text">{{ ingredients }}</p>
        </div>
        <div class="card-footer">
            <p class="card-price">{{ price }} ₽</p>
            <button class="btn btn-primary">Добавить</button>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";

@Component
export default class MenuItem extends Vue {
    @Prop() private name!: string;
    @Prop() private ingredients!: string;
    @Prop() private price!: number;
    @Prop() private picture!: string;
}
</script>

<style lang="scss">
    .card {
        width: 25%;
        padding: 0 15px;
        margin-bottom: 10px;
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
    }
    .card-price {
         color: #D94F2B;
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