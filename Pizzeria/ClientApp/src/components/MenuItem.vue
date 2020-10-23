<template>
    <div class="card">
        <div class="card-image">
            <img src="../assets/1.png" alt="">
        </div>
        <div class="card-content">
            <h5 class="card-title">Гавайская</h5>
            <p class="card-text">Цыпленок, томатный соус, моцарелла, ананасы</p>
        </div>
        <div class="card-footer">
            <p class="card-price">425 ₽</p>
            <button class="btn btn-primary">Добавить</button>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component
export default class MenuItem extends Vue {
    
}
</script>

<style lang="scss">
    .card {
        width: 25%;
        padding: 0 15px;
        margin-bottom: 10px;
    }

    .card-image {
        img {
            display: block;
            margin: 0 auto;
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