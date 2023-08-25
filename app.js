const express = require('express');
const swaggerUi = require('swagger-ui-express');
const swaggerDocument = require('./swagger.json');

const User = require('./index');

const app = express();


app.get('./users/:email', (req,res) =>{
    const { email } = req.params;
    const user = new User(email,'password')
    res.json(user);
});

app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerDocument));

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});