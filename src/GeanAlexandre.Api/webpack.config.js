const path = require('path')

module.exports = {
    entry: {
        'app': path.join(__dirname, 'app/app.js')
    },

    output: {
        path: path.join(__dirname, 'wwwroot'),
        filename: 'dist/[name].bundle.js',
        chunkFilename: 'dist/[id].chunk.js',
        publicPath: '/'
    }
}



