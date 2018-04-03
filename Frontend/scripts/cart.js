const cartId = localStorage.getItem('user');

fetch(`http://localhost:5000/api/cart/${cartId}`, {
  method: 'GET',
  headers: new Headers({
    'Accept': 'application/json',
    'Content-Type': 'application/json'
  })
}).then(res => res.json())
.then(carts => {
    Array.from(carts).forEach(cart => {
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
    Array.from(RemoveCarts).forEach(RemoveCart => {
      RemoveCart.addEventListener('click', () => {
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
