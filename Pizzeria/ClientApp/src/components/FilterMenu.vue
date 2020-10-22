<template>
    <div class="filter-wrapper">
        <div class="filter-search">
            <input class="search-input" type="text" name="search" id="search">
        </div>
        <div class="filter-sort">
            <select name="sort" id="sort" class="sort-select">
                <option value="">Сортировка по цене</option>
                <option value="От дешевых к дорогим">От дешевых к дорогим</option>
                <option value="От дорогих к дешевым">От дорогих к дешевым</option>
            </select>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component
export default class FilterMenu extends Vue {
    
}
</script>

<style lang="scss">
    .filter-wrapper {
        display: flex;
        justify-content: space-between;
        align-items: center;
        border-bottom: 4px solid #D94F2B;
        padding: 10px 0;
    }

    .filter-search {
        width: 50%;
    }

    .search-input {
        padding: 5px 10px;
        width: 100%;
    }

    .sort-select {
        padding: 5px 10px;
    }
</style>