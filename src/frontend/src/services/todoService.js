import axios from 'axios';

export default {
    getAllTodoItemsAsync () {
        return axios({
            method: 'get',
            url: '/services/todoService/getalltodos'
        });
    }
};