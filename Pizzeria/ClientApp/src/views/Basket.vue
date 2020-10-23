<template>
    <div class="basket-container">
        <h1 class="container-title">Корзина</h1>
        <BasketItem></BasketItem>
        <BasketItem></BasketItem>
        <div class="basket-total">
            <div class="total-label">Сумма заказа:</div>
            <div class="total-value">890 ₽</div>
        </div>
        <div class="basket-footer">
            <button class="btn btn-outline-primary">Вернуться в меню</button>
            <button class="btn btn-primary">Оформить заказ</button>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import BasketItem from "@/components/BasketItem.vue";

@Component({
  components: {
   BasketItem
  }
})
export default class Basket extends Vue {}
</script>

<style lang="scss">
    .container-title {
        border-bottom: 4px solid #D94F2B;
        margin-bottom: 20px;
        padding-bottom: 10px;
    }

    .basket-total {
        display: flex;
        justify-content: flex-end;
        align-items: center;
        font-size: 1.5rem;
        font-weight: 700;
        margin: 20px 0;
    }

    .total-value {
        color: #D94F2B;
        padding-left: 10px;
        font-size: 2rem;
    }

    .basket-footer {
        display: flex;
        justify-content: space-between;
    }
</style>