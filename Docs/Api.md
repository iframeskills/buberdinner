# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register      
```

### Register request

```json
{
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "password": "Amiko1232!"
}
```

### Register Response

```js
200 OK
```

```json
{
    "id": "980fc249-117b-4f10-990f-ff8684e1e6c1",
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "token": "eyJhb..z9dqcnXoY"
}
```


### Login

```js
POST {{host}}/auth/login
```

### Login Request

```json
{
    "email": "amichai@mantinband.com",
}
```