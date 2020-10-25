<template>
    <header class="header">
        <router-link to="/" class="align-self-center">
            <div class="header-title">Pizzeria</div>
        </router-link>
        <router-link to="/basket">
            <div class="header-basket">
                <img src="../assets/cart.svg" alt="" class="icon-cart" />
                <span class="basket-number" v-if="!$store.getters.basketIsEmpty">{{
                    $store.getters.positionCount
                }}</span>
            </div>
        </router-link>
    </header>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';

@Component
export default class Header extends Vue {}
</script>

<style scoped lang="scss">
.header {
    height: 90px;
    background-color: #151515;
    display: flex;
    justify-content: space-between;
}

.header-title {
    color: #d94f2b;
    padding: 0 15px;
    font-size: 1.5rem;
}

.header-basket {
    background: #fdbc2c;
    height: 100%;
    cursor: pointer;
    width: 90px;
    display: grid;
    place-items: center;
}

.icon-cart {
    width: 40px;
    height: 40px;
}

.basket-number {
    position: absolute;
    top: 25px;
    right: 15px;
    width: 18px;
    height: 18px;
    font-weight: 700;
    font-size: 12px;
    color: #151515;
    border-radius: 50%;
    background-color: #fff;
    display: grid;
    place-items: center;
}
</style>
