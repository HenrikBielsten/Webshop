const productsLists = document.querySelectorAll('.products');

const product_container = document.querySelector('.product_container');
const product_row = document.querySelector('.product_row');
const product_columns = document.querySelectorAll('.product_column');
// const cart =
// {
//     "cartid": "32",
//     "productid": "20"
// }

// fetch('http://localhost:5000/api/cart', {
//   method: 'POST', // or 'PUT'
//   body: JSON.stringify(cart),
//   headers: new Headers({
//     'Accept': 'application/json',
//         'Content-Type': 'application/json'
//   })
// }).then(res => res.json())
// .then(response => console.log('Success:', response));

function guid() {
  function s4() {
    return Math.floor((1 + Math.random()) * 0x10000)
      .toString(16)
      .substring(1);
  }
  return s4() + s4() + '-' + s4() + '-' + s4() + '-' + s4() + '-' + s4() + s4() + s4();
}
if (!localStorage.getItem('user')) {
  localStorage.setItem('user', `${guid()}`);
}

fetch('http://localhost:5000/api/product', {
  method: 'GET', // or 'PUT'
  body: JSON.stringify(),
  headers: new Headers({
    'Accept': 'application/json',
        'Content-Type': 'application/json'
  })
}).then(res => res.json())
.then(response => {

    for (const product of response)
    {

      const {id:product_id, name:product_name, price:product_price, slug:product_slug, productImage:product_img, description:product_description} = product;

      product_columns.forEach((column) => {

        const product_content = document.createElement('div');
        product_content.classList.add('product_content');
        product_content.classList.add('col-sm');
        product_content.classList.add('d-flex');
        product_content.classList.add('flex-column');
        product_content.classList.add('align-items-center');
        column.appendChild(product_content);

        const product_text = document.createElement('div');
        product_text.classList.add('product_text');
        product_content.appendChild(product_text);

        product_text.innerHTML += `<h1>${product_name}</h1>
        <p>${product_price} Kr</p>
        <img class="product_img" src="${product_img}">
        <p class="product_description">${product_description}</p>`;

        const button = document.createElement('button');
        button.classList.add('btn');
        button.classList.add('btn-primary');
        button.textContent = 'Add to Cart!';
        button.value = `${product_id}`;

        button.addEventListener('click', (e) => {

          const cookie = localStorage.getItem('user');

          const cart =
          {
              "cartId": cookie, //placeholder for cookieId
              "productId": button.value
          }

          console.log(cart);

          fetch('http://localhost:5000/api/cart', {
            method: 'POST',
            body: JSON.stringify(cart),
            headers: new Headers({
              'Accept': 'application/json',
                  'Content-Type': 'application/json'
            })
          })
          .then(response => console.log('Success:', response));
        })

        product_content.appendChild(button);

      })

    }

});
