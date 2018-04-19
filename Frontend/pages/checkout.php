<?php require __DIR__.'/../views/header.php'; ?>

<div class="d-flex justify-content-center row product_column">
</div>

<br>
<br>
<nav class="cart_total d-flex justify-content-between" style="font-weight: bold; height: 8vh; margin: 0; border-bottom: 2px solid orange;">
</nav>
<br>

<form class="form" action="/pages/ordered.php">
  <h4 style="text-decoration: underline; font-weight: bold;">Personal Information</h4>
  <div class="form-group">
    <label for="exampleFormControlInput1">Name</label>
    <input type="text" class="form-control name" id="exampleFormControlInput1" placeholder="Your full name" required>
  </div>
  <div class="form-group">
    <label for="exampleFormControlInput1">Email</label>
    <input type="text" class="form-control email" id="exampleFormControlInput1" placeholder="email@email.com" required>
  </div>
  <br>
  <br>
  <h4 style="text-decoration: underline; font-weight: bold;">Adress</h4>
  <div class="form-group">
    <label for="exampleFormControlInput1">Street and number</label>
    <input type="text" class="form-control street" id="exampleFormControlInput1" placeholder="Snake Lane 8c" required>
  </div>
  <div class="form-group">
    <label for="exampleFormControlInput1">City</label>
    <input type="text" class="form-control city" id="exampleFormControlInput1" placeholder="Elephant City" required>
  </div>
  <div class="form-group">
    <label for="exampleFormControlInput1">Post Code</label>
    <input type="text" class="form-control post_code" id="exampleFormControlInput1" placeholder="132 223" required>
  </div>
  <br>
  <br>
  <h4 style="text-decoration: underline; font-weight: bold;">Payment</h4>
  <div class="form-group">
    <label for="exampleFormControlSelect1">Select Region</label>
    <select class="form-control" id="exampleFormControlSelect1">
      <option>Europe</option>
      <option>Americas</option>
      <option>Africas</option>
      <option>Rest of the world</option>
    </select>
  </div>
  <div class="form-group">
    <label for="exampleFormControlSelect1">Payment options</label>
    <select class="form-control" id="exampleFormControlSelect1">
      <option>Debit Card</option>
      <option>Credit Card</option>
      <option>PayPal</option>
      <option>Klarna</option>
    </select>
  </div>
  <br>
  <button type="submit" class="btn btn-primary checkoutbutton">BUY!</button>
</form>
<br>
<br>

<script src="/../scripts/checkout.js" type="text/javascript"></script>

<?php require __DIR__.'/../views/footer.php'; ?>
