<template>
  <ul>
      <li v-for="item in todoItems" :key="item">
          {{ item }}
      </li>
  </ul>
</template>

<script>
import todoService from '../services/todoService.js'
export default {
    name: 'Todo',
    data () {
        return {
            todoItems: []
        };
    },
    async created () {
        const todoData = await todoService.getAllTodoItemsAsync();
        this.todoItems = todoData.data;
    }
}
</script>
