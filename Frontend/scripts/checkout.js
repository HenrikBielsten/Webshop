const cartId = localStorage.getItem('user');
const cart_total = document.querySelector('.cart_total')

let totalsum = 0;
let quantity = 0;

fetch(`http://localhost:5000/api/checkout/${cartId}`, {
  method: 'GET',
  headers: new Headers({
    'Accept': 'application/json',
    'Content-Type': 'application/json'
  })
}).then(res => res.json())
.then(carts => {

  carts = [...carts];

  const totalPrice = carts.reduce((total, cart) => cart.price + total, 0);

  carts.forEach(cart => {

  const cartList = document.querySelector('.product_column');

  cartList.innerHTML += `
  <div class="cart_content">
  <h3>${cart.name}</h3>
  <p class="cart_price">Price: ${cart.price} kr</p>
  <img class="cart_img" src=${cart.productImage}>
  <p class="cart_description">${cart.description}</p>
  </div>`;
})

   const totalDiv = document.createElement('div');
   cart_total.appendChild(totalDiv);
   totalDiv.innerHTML = 'Sum of products: ' + totalPrice + ' kr';

   const shipping = document.createElement('div');
   cart_total.appendChild(shipping);
   shipping.innerHTML = 'Shipping: 5500 kr';

   var sum = totalPrice + 5500;

   const total = document.createElement('div');
   cart_total.appendChild(total);
   total.innerHTML = 'Total: ' + sum + ' kr';


  const street = document.querySelector('.street');
  const city = document.querySelector('.city');
  const post_code = document.querySelector('.post_code');
  const emailDiv = document.querySelector('.email');
  const nameDiv = document.querySelector('.name');
  const checkoutbutton = document.querySelector('.checkoutbutton');


  document.querySelector('.form').addEventListener('submit', (event) => {
    event.preventDefault();

  const fulladress = street.value+', '+city.value+', '+post_code.value;
  const email = emailDiv.value;
  const name = nameDiv.value;

  const orders =
  {
      "price": sum,
      "adress": fulladress,
      "email": email,
      "name": name,
  }

  fetch('http://localhost:5000/api/checkout', {
    method: 'POST',
    body: JSON.stringify(orders),
    headers: new Headers({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    })
  })
  .then(response => console.log('Success:', response))
  .then(remove => localStorage.removeItem('user'))
  .then(redirect => window.location.replace("/../pages/ordered.php"));


})
});
