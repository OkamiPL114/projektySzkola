import './Users.css';

export default function Users(props){
    return(
        <div className='m-3'>
            {props.users.map(user => (
                <p key={user.id} className={"user " + (user.isValid ? 'valid' : 'invalid')}>{user.name}, {user.email}</p>
            ))}
        </div>
    );
}