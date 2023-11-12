# Project

**תיאור הפרוייקט:** &&
מערכת לניהול אתר קניות. באמצעות המערכת ניתן לנהל את רשימת המוצרים, לצפות בהזמנות שביצעו הלקוחות ואחר רשימת הלקוחות.&&

**ישויות:**&&
-מוצר Product
-לקוח Customer
-הזמנה Order

**Routes for Product**
GET [https://HerbalStore.co.il/products]   שליפת רשימת מוצרים
GET [https://HerbalStore.co.il/products/1]   שליפת מוצר לפי מזהה
POST [https://HerbalStore.co.il/products]   הוספת מוצר
PUT [https://HerbalStore.co.il/products/1]   עדכון מוצר
DELETE [https://HerbalStore.co.il/products/1]   מחיקת מוצר

**Routes for Customer**
GET [https://HerbalStore.co.il/customers]   שליפת רשימת לקוחות
GET [https://HerbalStore.co.il/customers/1]   שליפת לקוח לפי מזהה
POST [https://HerbalStore.co.il/customers]   הוספת לקוח
PUT [https://HerbalStore.co.il/customers/1]   עדכון לקוח

**Routes for Order**
GET [https://HerbalStore.co.il/orders]   שליפת רשימת הזמנות
GET [https://HerbalStore.co.il/orders/1]   שליפת הזמנה לפי מזהה
POST [https://HerbalStore.co.il/orders]   הוספת הזמנה
PUT [https://HerbalStore.co.il/orders/1]   עדכון הזמנה
DELETE [https://HerbalStore.co.il/orders/1]   מחיקת הזמנה





