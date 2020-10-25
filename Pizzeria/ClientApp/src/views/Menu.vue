<template>
    <div>
        <FilterMenu></FilterMenu>
        <div class="menu-container">
            <MenuItem v-for="pizza in pizzas" :key="pizza.id" :pizza="pizza"></MenuItem>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import FilterMenu from '@/components/FilterMenu.vue';
import MenuItem from '@/components/MenuItem.vue';
import { Pizza } from '@/Types';

@Component({
    components: {
        FilterMenu,
        MenuItem
    }
})
export default class Menu extends Vue {
    pizzas: Pizza[] = [];

    async mounted() {
        this.pizzas = (await this.$axios.get('/api/pizzas')).data;
    }
}
</script>

<style lang="scss">
.menu-container {
    display: flex;
    flex-wrap: wrap;
    padding-top: 20px;
}
</style>
