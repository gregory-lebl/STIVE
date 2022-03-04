//Récupère tous les produits et les quantités du panier pour 
function getTotalPrice() {
    let allCheckoutItems = document.querySelectorAll(".checkout-item .checkout-item-product-quantity-price-value")
    let totalPrice = 0;

    allCheckoutItems.forEach(
        item => totalPrice += parseFloat(item.innerHTML.replace(",", "."))
    )

    document.querySelector(".checkout-price .checkout-price-total-product").innerHTML = "Produits: " + totalPrice.toFixed(2) + " €"
    document.querySelector(".checkout-price .checkout-price-total").innerHTML = "Total: " + totalPrice.toFixed(2) + " €"
}

//Change le prix d'une commande en fonction de la quantitée commandée
$(".checkout-item-product-quantity-input").on('change', function () {
    let itemId = $(this).attr("data-itemId")
    let element = $(".checkout-item-" + itemId) 
    let unitPrice = $(element).find(".checkout-item-product-info-price-value").text().replace(",",".")
    let quantity = $(element).find(".checkout-item-product-quantity-input").val()
    let newPrice = unitPrice * quantity
    newPrice = parseFloat(newPrice).toFixed(2)
    $(element).find(".checkout-item-product-quantity-price-value").text(newPrice.toString().replace(".", ","))

    getTotalPrice()
})
