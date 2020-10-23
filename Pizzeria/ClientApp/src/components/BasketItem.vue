<template>
    <article class="item">
        <img class="item-img" src="../assets/1.png" alt="">
        <main class="item-content">
            <h5>Гавайская</h5>
            <p>Цыпленок, томатный соус, моцарелла, ананасы</p>
        </main>
        <div class="item-control">
            <button class="control-btn"> - </button>
            <span> 2 </span>
            <button class="control-btn"> + </button>
        </div>
        <div class="item-price">890 ₽</div>
        <div class="item-delete">Удалить</div>
    </article>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component
export default class BasketItem extends Vue {
    
}
</script>

<style lang="scss" scoped>
    .item {
        display: flex;
        align-items: center;
        box-shadow: 0px 2px 0px 0px #010202;
        border-bottom: 1px solid #383838;
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
                color: #D94F2B;
            }
        }
    }

    .item-price {
        color: #D94F2B;
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
    }
</style>