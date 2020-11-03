const path = require('path');

module.exports = {
    entry: './main.ts',
    devServer: {
        contentBase: '../dist'
    },
    devtool: '',
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                use: '',
                exclude: /node_modules/
            }
        ]
    },
    resolve: {},
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'dist')
    }
};
