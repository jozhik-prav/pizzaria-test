<template>
    <div class="filter-wrapper">
        <div class="filter-search">
            <input class="search-input form-control" type="text" name="search" id="search">
        </div>
        <div class="filter-sort form-control">
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
        @media screen and (max-width: 480px) {
            flex-direction: column;
            align-items: start;
        }
    }

    .filter-search {
        width: 50%;
        @media screen and (max-width: 480px) {
            width: 100%;
        }
    }

    .search-input {
        padding: 5px 10px;
        width: 100%;
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

    .form-control {
        padding: 10px 20px;
        color: #fff;
        background-image: none;
        border: 1px solid #cccccc;
        transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
        background-color: transparent;
        margin-bottom: 15px;
        display: block;
        &:focus {
            border-color: #66afe9;
            outline: 0;
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(102, 175, 233, 0.6);
        }
    }
</style>