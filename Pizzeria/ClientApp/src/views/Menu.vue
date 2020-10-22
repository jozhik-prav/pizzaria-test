<template>
  <div>
      <FilterMenu></FilterMenu>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import FilterMenu from "@/components/FilterMenu.vue"; // @ is an alias to /src

@Component({
  components: {
   FilterMenu
  }
})
export default class Menu extends Vue {}
</script>
