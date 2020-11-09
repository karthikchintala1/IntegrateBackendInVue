module.exports = {
    devServer: {
        proxy: {
            '/services/todoService': {
                target: 'http://localhost:5000',
                ws: true,
                pathRewrite: {
                    '^/services/todoService': '/'
                }
            }
        }
    }
};