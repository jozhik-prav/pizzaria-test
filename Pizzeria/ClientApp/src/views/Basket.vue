<template>
    <div class="basket-container">
        <h1 class="container-title">Корзина</h1>
        <BasketItem v-for="item in this.$store.state.basket" :key="item.index" :orderLine="item"></BasketItem>
        <div v-if="$store.getters.basketIsEmpty">В корзине нет товаров</div>
        <div class="basket-discount">
            <div class="discount-label">Скидка:</div>
            <div class="discount-value">-{{ this.$store.getters.discountSum }} ₽</div>
        </div>
        <div class="basket-total">
            <div class="total-label">Сумма заказа:</div>
            <div class="total-value">{{ this.$store.getters.totalSum }} ₽</div>
        </div>
        <div class="basket-footer">
            <router-link to="/">
                <button class="btn btn-outline-primary">Вернуться в меню</button>
            </router-link>
            <button class="btn btn-primary" @click="send()">Оформить заказ</button>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import BasketItem from '@/components/BasketItem.vue';
import { OrderLine } from '@/Types';

@Component({
    components: {
        BasketItem
    }
})
export default class Basket extends Vue {
    async send() {
        const basket: OrderLine[] = this.$store.state.basket;
        const orderLines = basket.map(x => ({
            pizzaId: x.pizza.id,
            count: x.count
        }));
        try {
            const response = await this.$axios.post('/api/orders', { orderLines });
            alert(`Спасибо за ваш заказ. Номер заказа:${response.data}`);
        } catch (error) {
            alert('Ваш заказ очень важен для нас. В данный момент все менеджеры заняты. Перезвоните позже');
            console.error(error);
            console.error(error.response);
        }
    }
}
</script>

<style lang="scss">
.container-title {
    border-bottom: 4px solid #d94f2b;
    margin-bottom: 20px;
    padding-bottom: 10px;
}

.basket-total,
.basket-discount {
    display: flex;
    justify-content: flex-end;
    align-items: center;
    font-size: 1.5rem;
    font-weight: 700;
    margin: 20px 0;
}

.total-value,
.discount-value {
    color: #d94f2b;
    padding-left: 10px;
    font-size: 2rem;
}

.basket-footer {
    display: flex;
    justify-content: space-between;
}
</style>
