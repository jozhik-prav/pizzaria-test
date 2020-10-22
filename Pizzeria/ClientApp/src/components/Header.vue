<template>
    <header class="header">
        <div class="header-title">Pizzeria</div>
        <div class="header-btn">
            <span>Корзина</span>
        </div>
    </header>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component
export default class Header extends Vue {
    
}
</script>

<style scoped lang="scss">

    .header {
        height: 90px;
        background-color: #151515;
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .header-title {
        color: #D94F2B;
        padding: 0 15px;
        font-size: 1.5rem;
    }

    .header-btn {
        background: #fdbc2c;
        height: 100%;
        cursor: pointer;
        span {
            padding: 35px 10px;
            display: block;
        }
    }

</style>