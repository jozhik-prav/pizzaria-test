<template>
    <div>
        <div class="filter-wrapper">
            <div class="filter-search">
                <input class="search-input form-control" type="text" name="search" id="search" v-model="searchText" />
                <img src="../assets/search.svg" alt="" class="icon-search" />
            </div>
            <div class="filter-sort form-control">
                <select name="sort" id="sort" class="sort-select" v-model="sortMethod">
                    <option value="none">Сортировка по цене</option>
                    <option value="asc">От дешевых к дорогим</option>
                    <option value="desc">От дорогих к дешевым</option>
                </select>
            </div>
        </div>
        <div class="menu-container">
            <MenuItem v-for="pizza in sortedList" v-show="isShow(pizza)" :key="pizza.id" :pizza="pizza"></MenuItem>
            <div v-if="pizzas.length == 0">Пицц нет :( Приходите позже</div>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import MenuItem from '@/components/MenuItem.vue';
import { Pizza } from '@/Types';

@Component({
    components: {
        MenuItem
    }
})
export default class Menu extends Vue {
    pizzas: Pizza[] = [];

    searchText = '';

    get lowerCaseSearchText() {
        return this.searchText.toLowerCase();
    }

    isShow(pizza: Pizza): boolean {
        return pizza.name.toLowerCase().includes(this.lowerCaseSearchText);
    }

    sortMethod: 'none' | 'asc' | 'desc' = 'none';

    get sortedList(): Pizza[] {
        switch (this.sortMethod) {
            case 'none':
                return this.pizzas;
            case 'asc':
                return [...this.pizzas].sort((a, b) => a.price - b.price);
            case 'desc':
                return [...this.pizzas].sort((a, b) => b.price - a.price);
            default:
                throw new Error('Неожиданный метод сортировки');
        }
    }

    async mounted() {
        this.pizzas = (await this.$axios.get('/api/pizzas')).data;
    }
}
</script>

<style lang="scss">
.menu-container {
    display: flex;
    flex-wrap: wrap;
    padding: 40px 0;
}
.filter-wrapper {
    display: flex;
    justify-content: space-between;
    align-items: center;
    border-bottom: 4px solid #d94f2b;
    padding: 10px 0;
    @media screen and (max-width: 480px) {
        flex-direction: column;
        align-items: start;
    }
}

.filter-search {
    width: 50%;
    position: relative;
    @media screen and (max-width: 480px) {
        width: 100%;
    }
}

.form-control {
    padding: 10px 20px;
    color: #fff;
    background-image: none;
    border: 1px solid #cccccc;
    transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
    background-color: transparent;
    margin-bottom: 15px;
    display: block;
    &:focus {
        border-color: #66afe9;
        outline: 0;
        box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(102, 175, 233, 0.6);
    }
}

.search-input {
    padding-left: 35px;
    width: 100%;
}

.filter-sort {
    padding: 7px 20px;
}

.sort-select {
    border: none;
    outline: none;
    background: transparent;
    color: inherit;
    option {
        color: #000;
    }
}

.icon-search {
    width: 20px;
    position: absolute;
    top: 8px;
    left: 8px;
}
</style>
