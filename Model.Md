**Tables:**

1. **Clients:**
    * ClientID (INT, Primary Key)
    * FirstName (VARCHAR(50))
    * LastName (VARCHAR(50))
    * Email (VARCHAR(100))
    * PhoneNumber (VARCHAR(20))

2. **Barbers:**
    * BarberID (INT, Primary Key)
    * FirstName (VARCHAR(50))
    * LastName (VARCHAR(50))
    * Bio (TEXT) - : Short bio about the barber's experience or specialties.
    * Availability (Bool) -: To store barber's availability for appointments so as to avoid Multiple bookings.

3. **Services:**
    * ServiceID (INT, Primary Key)
    * ServiceName (VARCHAR(50))
    * Description (TEXT) - : A brief description of the service.
    * Price (DECIMAL(10,2))

4. **Appointments:**
    * AppointmentID (INT, Primary Key)
    * ClientID (INT, Foreign Key references Clients(ClientID))
    * BarberID (INT, Foreign Key references Barbers(BarberID))
    * ServiceID (INT, Foreign Key references Services(ServiceID))
    * DateTime (DATETIME)

**Relationships:**

* One Client can have many Appointments. (One-to-Many)
* One Barber can have many Appointments. (One-to-Many)
* One Service can be included in many Appointments. (One-to-Many)
  

**Additional Tables (Maybe in the future):**

* **Products:** To store information about hair care products sold at the salon.
* **Inventory:** To track the stock levels of products.
* **Promotions:** To manage special offers and discounts.

