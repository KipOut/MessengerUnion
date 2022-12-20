const Pool = require('pg').Pool
const pool = new Pool({
    user: 'postgres',
    password: '*curs7#%2Kvnd',
    host: 'localhost',
    port: 5432,
    database: 'unionmessenger'
})

module.exports = pool