<template>
  <div>
      <FilterMenu></FilterMenu>
      <div class="menu-container">
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
          <MenuItem></MenuItem>
      </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import FilterMenu from "@/components/FilterMenu.vue";
import MenuItem from "@/components/MenuItem.vue";

@Component({
  components: {
   FilterMenu,
   MenuItem
  }
})
export default class Menu extends Vue {}
</script>

<style lang="scss">
    .menu-container {
        display: flex;
        flex-wrap: wrap;
        padding-top: 20px;
    }
</style>
