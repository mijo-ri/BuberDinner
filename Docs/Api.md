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

#### Register Request

```json
{
    "firstName": "Michael John",
    "lastName": "Rieser",
    "email": "michi.rieser@gmail.com",
    "password": "myS3curePassw0rd!"
}
```

#### Register Response

```json
{
    "id": "1234abcd"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json

```

#### Login Response

```json

```