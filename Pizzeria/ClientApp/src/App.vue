<template>
    <div id="app">
        <Header></Header>
        <div class="container">
            <router-view />
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import Header from '@/components/Header.vue';

@Component({
    components: {
        Header
    }
})
export default class App extends Vue {}
</script>

<style lang="scss">
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

a {
    text-decoration: none;
}

.align-self-center {
    align-self: center;
}

html {
    font-size: 18px;
    background: #333 url(assets/pattern-body.jpg);
    color: #fff;
}

.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 10px 15px;
}

#app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
}

.btn {
    margin-bottom: 14px;
    padding: 10px 25px;
    font-size: 14px;
    font-weight: 700;
    border-width: 2px;
    border-style: solid;
    transition: all 0.3s;
    text-transform: uppercase;
    background: transparent;
    cursor: pointer;
    @media screen and (max-width: 768px) {
        padding: 10px;
    }
}

.btn-primary {
    background-color: #fdbc2c;
    border-color: #fdbc2c;
    &:hover {
        background: #d94f2b;
        color: #fff;
    }
}

.btn-outline-primary {
    border-color: #fdbc2c;
    color: #fff;
    &:hover {
        background: #d94f2b;
    }
}
</style>
