const cartId = localStorage.getItem('user');
const cart_total = document.querySelector('.cart_total')

fetch(`http://localhost:5000/api/cart/${cartId}`, {
  method: 'GET',
  headers: new Headers({
    'Accept': 'application/json',
    'Content-Type': 'application/json'
  })
}).then(res => res.json())
.then(carts => {

  carts = [...carts];

  const totalPrice = carts.reduce((total, cart) => cart.price + total, 0);

   const totalDiv = document.createElement('div');
   cart_total.appendChild(totalDiv);
   totalDiv.innerHTML = 'Total price: ' + totalPrice + ' kr';

    carts.forEach(cart => {

    const cartList = document.querySelector('.product_column');

    cartList.innerHTML += `
    <div class="cart_content">
    <h3>${cart.name}</h3>
    <p class="cart_price">Price: ${cart.price} kr</p>
    <img class="cart_img" src=${cart.productImage}>
    <p class="cart_description">${cart.description}</p>
    <button class="RemoveCart btn btn-danger" type="button" value="${cart.id}" name="button">Remove from cart</button>
    </div>`

    const RemoveCarts = document.querySelectorAll('.RemoveCart');

    // console.log(cart);

    // cart.splice(cart.indexOf(RemoveCart.value = cart.id), 1 );

    Array.from(RemoveCarts).forEach(RemoveCart => {
      RemoveCart.addEventListener('click', () => {

      this.element.remove();

      fetch(`http://localhost:5000/api/cart/${cartId}/${RemoveCart.value}`, {
        method: 'DELETE',
        headers: new Headers({
          'Accept': 'application/json',
          'Content-Type': 'application/json'
          })
        })
        .then(response => console.log('Success:', response));
      })
    })
  })
});
